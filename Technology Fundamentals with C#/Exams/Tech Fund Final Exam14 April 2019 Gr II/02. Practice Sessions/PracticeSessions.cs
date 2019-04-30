namespace _02._Practice_Sessions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PracticeSessions
    {
        public static void Main()
        {
            var roads = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                if (command == "Add")
                {
                    string road = tokens[1];
                    string racer = tokens[2];

                    if (!roads.ContainsKey(road))
                    {
                        roads.Add(road, new List<string>());
                    }
                    roads[road].Add(racer);
                }
                else if (command == "Move")
                {
                    string currentRoad = tokens[1];
                    string racer = tokens[2];
                    string newRoad = tokens[3];

                    if (roads[currentRoad].Contains(racer))
                    {
                        roads[currentRoad].Remove(racer);
                        roads[newRoad].Add(racer);
                    }

                }
                else if (command == "Close")
                {
                    string road = tokens[1];
                    if (roads.ContainsKey(road))
                    {
                        roads.Remove(road);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Practice sessions:");
            foreach (var item in roads.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"++{kvp}");
                }
            }
        }
    }
}
