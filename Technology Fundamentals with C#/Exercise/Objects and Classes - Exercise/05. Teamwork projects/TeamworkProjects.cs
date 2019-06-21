namespace _05._Teamwork_projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TeamworkProjects
    {
        public class Team
        {
            public string Name { get; set; }

            public string Creator { get; set; }

            public List<string> Members { get; set; }
        }

        public static void Main()
        {
            int countOfTeamsToReg = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < countOfTeamsToReg; i++)
            {
                string[] teamCreate = Console.ReadLine().Split('-');
                string teamCreator = teamCreate[0];
                string teamName = teamCreate[1];
                Team team = new Team();
                team.Name = teamName;
                team.Creator = teamCreator;
                team.Members = new List<string>();
                if (!teams.Select(t => t.Name).Contains(team.Name))
                {
                    if (!teams.Select(x => x.Creator).Contains(teamCreator))
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{teamCreator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] tokens = input.Split("->");
                string user = tokens[0];
                string team = tokens[1];
                if (!teams.Select(t => t.Name).Contains(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teams.Select(t => t.Members).Any(t => t.Contains(user)) || teams.Select(t => t.Creator).Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }
                else
                {
                    int teamIndex = teams.FindIndex(t => t.Name == team);
                    teams[teamIndex].Members.Add(user);
                }

                input = Console.ReadLine();
            }

            List<Team> disbandTeam = new List<Team>();
            List<Team> fullTeams = new List<Team>();
            foreach (var team in teams)
            {
                if (team.Members.Count == 0)
                {
                    disbandTeam.Add(team);
                }
                else
                {
                    fullTeams.Add(team);
                }
            }

            foreach (var team in fullTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandTeam.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
