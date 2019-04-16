using System;

namespace _06._Journey
{
    class Journey
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = string.Empty;
            string typeVacantion = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                place += "Bulgaria";
                if (season == "summer")
                {
                    typeVacantion += "Camp";
                    price += budget * 0.30;
                }
                else if (season == "winter")
                {
                    typeVacantion += "Hotel";
                    price += budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                place += "Balkans";
                if (season == "summer")
                {
                    typeVacantion += "Camp";
                    price += budget * 0.4;
                }
                else if (season == "winter")
                {
                    typeVacantion += "Hotel";
                    price += budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                place += "Europe";
                typeVacantion += "Hotel";
                price += budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{typeVacantion} - {price:f2}");
        }
    }
}
