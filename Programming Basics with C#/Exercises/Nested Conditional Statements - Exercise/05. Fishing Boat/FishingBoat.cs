using System;

namespace _05._Fishing_Boat
{
    class FishingBoat
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishermans = int.Parse(Console.ReadLine());

            double rent = 0;

            if (season == "Spring")
            {
                rent += 3000;
            }
            else if (season =="Summer")
            {
                rent += 4200;
            }
            else if (season =="Autumn")
            {
                rent += 4200;
            }
            else if (season == "Winter")
            {
                rent += 2600;
            }
            if (countFishermans<= 6)
            {
                rent -= rent * 0.1;
            }
            else if (countFishermans>=7 && countFishermans <=11)
            {
                rent -= rent * 0.15;
            }
            else if (countFishermans>=12)
            {
                rent -= rent * 0.25;
            }
            if (countFishermans %2 == 0 && season != "Autumn")
            {
                rent -= rent * 0.05;
            }
            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {budget-rent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rent-budget:f2} leva.");
            }
        }
    }
}
