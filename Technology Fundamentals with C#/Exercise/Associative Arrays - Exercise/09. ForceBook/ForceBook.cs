namespace _09._ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForceBook
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            while (command != "Lumpawaroo")
            {
                if (command.Contains("->"))
                {
                    string[] info = command.Split("->");
                    string user = info[0].Trim();
                    string side = info[1].Trim();
                    if (sides.Values.Any(u => u.Contains(user)))
                    {
                        sides.Values.Any(u => u.Remove(user));
                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        Console.WriteLine($"{user} joins the {side} side!");
                    }

                    sides[side].Add(user);
                }
                else
                {
                    string[] info = command.Split("|");
                    string user = info[1].Trim();
                    string side = info[0].Trim();

                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (!sides.Values.Any(u => u.Contains(user)))
                    {
                        sides[side].Add(user);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in sides.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                kvp.Value.Sort();
                if (kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    Console.WriteLine("! " + string.Join(Environment.NewLine+ "! ", kvp.Value));
                }
            }
        }
    }
}