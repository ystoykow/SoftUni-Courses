using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> concert = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();
            while (command != "start of concert")
            {
                string[] tokens = command.Split("; ");
                if (tokens[0] == "Add")
                {
                    string bandName = tokens[1];
                    string[] bandMembers = tokens[2].Split(", ");
                    if (!concert.ContainsKey(bandName))
                    {
                        concert.Add(bandName, new List<string>());
                    }
                    for (int i = 0; i < bandMembers.Length; i++)
                    {
                        if (!concert[bandName].Contains(bandMembers[i]))
                        {
                            concert[bandName].Add(bandMembers[i]);
                        }
                    }
                }
                else if (tokens[0] == "Play")
                {
                    string bandName = tokens[1];
                    int time = int.Parse(tokens[2]);
                    if (!bandTime.ContainsKey(bandName))
                    {
                        bandTime.Add(bandName, time);
                    }
                    else if (bandTime.ContainsKey(bandName))
                    {
                        bandTime[bandName] += time;
                    }
                }

                command = Console.ReadLine();
            }
            string band = Console.ReadLine();
            int totalTime = 0;
            foreach (var item in bandTime)
            {
                totalTime += item.Value;
            }
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var item in bandTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            foreach (var item in concert.Where(x=>x.Key==band))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($" => {kvp}");
                }
            }
        }
    }
}
