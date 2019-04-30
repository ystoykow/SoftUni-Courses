namespace _04_International_SoftUniada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InternationalSoftUniada
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> listedCountry = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string country = tokens[0];
                string name = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!listedCountry.ContainsKey(country))
                {
                    listedCountry.Add(country, new Dictionary<string, int>());
                    listedCountry[country].Add(name, points);
                }
                else if (listedCountry[country].ContainsKey(name))
                {
                    listedCountry[country][name] += points;
                }
                else if (!listedCountry[country].ContainsKey(name))
                {
                    listedCountry[country].Add(name, points);
                }
                
                    input = Console.ReadLine();
            }
            foreach (var item in listedCountry.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()}");
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($" -- {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
