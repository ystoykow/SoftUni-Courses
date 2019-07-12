namespace _04._Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Snowwhite
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
            while (input != "Once upon a time")
            {
                string[] tokens = input.Split("<:>");
                string name = tokens[0].Trim();
                string color = tokens[1].Trim();
                int physics = int.Parse(tokens[2].Trim());
                if (!dwarfs.ContainsKey(color))
                {
                    dwarfs.Add(color, new Dictionary<string, int>());
                    dwarfs[color].Add(name, physics);
                }
                else if (dwarfs.ContainsKey(color) && !dwarfs[color].ContainsKey(name))
                {
                    dwarfs[color].Add(name, physics);
                }
                else if (dwarfs.ContainsKey(color) && dwarfs[color].ContainsKey(name))
                {
                    if (dwarfs[color][name] < physics)
                    {
                        dwarfs[color][name] = physics;
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var item in dwarfs.OrderByDescending(x => x.Value.Count))
            {
                foreach (var kvp in item.Value)
                {
                    string dwarfPair = "(" + item.Key + ") " + kvp.Key + " <->";
                    sortedDwarfs.Add(dwarfPair, kvp.Value);
                }
            }

            foreach (var item in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}