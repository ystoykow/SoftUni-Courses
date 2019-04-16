using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, double> gamesWithDLC = new Dictionary<string, double>();
            Dictionary<string, double> gamesWithoutDLC = new Dictionary<string, double>();
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Contains('-'))
                {
                    string[] game = games[i].Split('-');
                    if (!gamesWithoutDLC.ContainsKey(game[0]))
                    {
                        gamesWithoutDLC.Add(game[0], double.Parse(game[1]));
                    }
                }
            }
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Contains(':'))
                {
                    string[] game = games[i].Split(':');
                    if (gamesWithoutDLC.ContainsKey(game[0]))
                    {
                        string gameName = game[0];
                        string gameDLC = game[1];
                        double gamePrice = gamesWithoutDLC[gameName] * 1.2;

                        string resultGameName = gameName + " - " + gameDLC;

                        gamesWithDLC.Add(resultGameName, gamePrice);

                        gamesWithoutDLC.Remove(gameName);
                    }
                }
            }
            Dictionary<string, double> gamesWithoutDLCDiscounted = new Dictionary<string, double>();
            foreach (var item in gamesWithoutDLC)
            {
                gamesWithoutDLCDiscounted.Add(item.Key, item.Value * 0.8);
            }
            Dictionary<string, double> gamesWithDLCdiscounted = new Dictionary<string, double>();
            foreach (var item in gamesWithDLC)
            {
                gamesWithDLCdiscounted.Add(item.Key, item.Value * 0.5);
            }
            foreach (var item in gamesWithDLCdiscounted.OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value:f2}");
            }
            foreach (var item in gamesWithoutDLCDiscounted.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value:f2}");
            }
        }
    }
}
