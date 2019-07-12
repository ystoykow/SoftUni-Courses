namespace _01._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ranking
    {
        public static void Main()
        {
            Dictionary<string, string> contest = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] token = input.Split(':');
                string contestName = token[0].Trim();
                string contestPass = token[1].Trim();
                contest.Add(contestName, contestPass);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of submissions")
            {
                string[] token = input.Split("=>");
                string contestName = token[0].Trim();
                string contestPass = token[1].Trim();
                string user = token[2].Trim();
                int points = int.Parse(token[3].Trim());

                if (contest.ContainsKey(contestName) && contest[contestName].Contains(contestPass))
                {
                    if (!submissions.ContainsKey(user))
                    {
                        submissions.Add(user, new Dictionary<string, int>());
                        submissions[user].Add(contestName, points);
                    }
                    else if (submissions.ContainsKey(user) && !submissions[user].ContainsKey(contestName))
                    {
                        submissions[user].Add(contestName, points);
                    }
                    else if (submissions.ContainsKey(user) && submissions[user].ContainsKey(contestName) && submissions[user][contestName] < points)
                    {
                        submissions[user][contestName] = points;
                    }
                }

                input = Console.ReadLine();
            }

            string winner = string.Empty;
            int maxPoints = 0;
            foreach (var kvp in submissions)
            {
                int currentMax = 0;
                var innerKvp = kvp.Value;
                foreach (var item in innerKvp)
                {
                    currentMax += item.Value;
                    if (maxPoints < currentMax)
                    {
                        maxPoints = currentMax;
                        winner = kvp.Key;
                    }
                }
            }

            Console.WriteLine($"Best candidate is {winner} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var kvp in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                var innerKvp = kvp.Value;
                foreach (var item in innerKvp.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
