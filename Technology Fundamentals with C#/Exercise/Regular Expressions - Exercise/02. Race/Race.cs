namespace _02._Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Race
    {
        public static void Main()
        {
            string patternForNames = @"([A-Z]|[a-z])";
            string patternForDigits = @"[0-9]";
            List<string> racers = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            Dictionary<string, int> raceStats = new Dictionary<string, int>();
            while (input != "end of race")
            {
                string name = string.Empty;
                int sumKm = 0;
                MatchCollection nameSymbols = Regex.Matches(input, patternForNames);
                MatchCollection racerKm = Regex.Matches(input, patternForDigits);

                foreach (Match symbol in nameSymbols)
                {
                    name += symbol.ToString();
                }

                foreach (Match km in racerKm)
                {
                    sumKm += int.Parse(km.Value);
                }

                if (racers.Contains(name))
                {
                    if (!raceStats.ContainsKey(name))
                    {
                        raceStats.Add(name, 0);
                    }

                    raceStats[name] += sumKm;
                }

                input = Console.ReadLine();
            }

            int i = 1;
            foreach (var racer in raceStats.OrderByDescending(x => x.Value))
            {
                if (i == 1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                }

                i++;
            }
        }
    }
}
