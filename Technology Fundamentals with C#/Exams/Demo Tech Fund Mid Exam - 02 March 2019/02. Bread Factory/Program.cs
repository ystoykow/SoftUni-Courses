using System;

namespace _02._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = Console.ReadLine().Split('|');
            int coins = 100;
            int energy = 100;
            bool isBankrud = false;
            for (int i = 0; i < events.Length; i++)
            {
                string[] tokens = events[i].Split('-');
                string task = tokens[0];
                int coin = int.Parse(tokens[1]);
                if (task=="rest")
                {
                    if (energy+coin>100)
                    {
                        Console.WriteLine($"You gained {100-energy} energy.");
                        energy = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You gained {coin} energy.");
                        energy += coin;
                    }
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (task=="order")
                {
                    if (energy - 30 >= 0)
                    {
                        energy -= 30;
                        coins += coin;
                        Console.WriteLine($"You earned {coin} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    if (coins - coin > 0)
                    {
                        coins -= coin;
                        Console.WriteLine($"You bought {task}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {task}.");
                        isBankrud = true;
                        break;
                    }
                }
            }
            if (!isBankrud)
            {
                Console.WriteLine($"Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}
