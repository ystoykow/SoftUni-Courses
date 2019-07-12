namespace _02._Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Judge
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> content = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> userSumPoints = new Dictionary<string, int>();
            while (input != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string contest = tokens[1].Trim();
                string user = tokens[0].Trim();
                int points = int.Parse(tokens[2].Trim());
                if (!content.ContainsKey(contest))
                {
                    content.Add(contest, new Dictionary<string, int>());
                    content[contest].Add(user, points);
                }
                else if (content.ContainsKey(contest) && !content[contest].ContainsKey(user))
                {
                    content[contest].Add(user, points);
                }
                else
                {
                    if (content[contest][user] < points)
                    {
                        content[contest][user] = points;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in content)
            {
                var innerKvp = kvp.Value;
                foreach (var item in innerKvp)
                {
                    if (!userSumPoints.ContainsKey(item.Key))
                    {
                        userSumPoints.Add(item.Key, 0);
                    }

                    userSumPoints[item.Key] += item.Value;
                }
            }

            foreach (var kvp in content)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");
                var innerKvp = kvp.Value;
                int i = 1;
                foreach (var item in innerKvp.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{i}. {item.Key} <::> {item.Value}");
                    i++;
                }
            }

            Console.WriteLine($"Individual standings:");
            int j = 1;
            foreach (var kvp in userSumPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{j}. {kvp.Key} -> {kvp.Value}");
                j++;
            }
        }
    }
}
