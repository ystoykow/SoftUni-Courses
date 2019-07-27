namespace _01._Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Concert
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();
            while (input != "start of concert")
            {
                string[] tokens = input.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string bandName = tokens[1];
                if (command == "Play")
                {
                    int time = int.Parse(tokens[2]);
                    if (!bandTime.ContainsKey(bandName))
                    {
                        bandTime.Add(bandName, 0);
                    }

                    bandTime[bandName] += time;
                }
                else
                {
                    string[] bandMembers = tokens[2].Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    if (!members.ContainsKey(bandName))
                    {
                        members.Add(bandName, new List<string>());
                    }

                    for (int i = 0; i < bandMembers.Length; i++)
                    {
                        string currentMember = bandMembers[i];
                        if (!members[bandName].Contains(currentMember))
                        {
                            members[bandName].Add(currentMember);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Total time: {bandTime.Values.Sum()}");
            foreach (var band in bandTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string bandNameToShow = Console.ReadLine();
            Console.WriteLine(bandNameToShow);
            foreach (var member in members[bandNameToShow])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
