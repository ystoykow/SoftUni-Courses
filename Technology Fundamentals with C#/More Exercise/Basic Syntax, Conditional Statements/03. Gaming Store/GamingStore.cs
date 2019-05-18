namespace _03._Gaming_Store
{
    using System;
    using System.Collections.Generic;

    class GamingStore
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());

            var games = new Dictionary<string, double>();

            games.Add("OutFall 4", 39.99);
            games.Add("CS: OG", 15.99);
            games.Add("Zplinter Zell", 19.99);
            games.Add("Honored 2", 59.99);
            games.Add("RoverWatch", 29.99);
            games.Add("RoverWatch Origins Edition", 39.99);

            string input = Console.ReadLine();
            double spend = 0;

            while(input!="Game Time")
            {

                if (!games.ContainsKey(input))
                {
                    Console.WriteLine("Not Found");
                }
                else if (games.ContainsKey(input))
                {
                    if (games[input]<=balance)
                    {
                        balance -= games[input];
                        spend += games[input];

                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                if (balance == 0)
                {
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${balance:f2}");
        }
    }
}
