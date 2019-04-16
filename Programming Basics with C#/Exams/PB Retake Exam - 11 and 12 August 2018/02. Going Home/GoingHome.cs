using System;

namespace _02._Going_Home
{
    class GoingHome
    {
        static void Main()
        {
            double distanceInKM = double.Parse(Console.ReadLine());
            double fuelPer100km = double.Parse(Console.ReadLine());
            double fuelPricePerLiter = double.Parse(Console.ReadLine());
            double profit = double.Parse(Console.ReadLine());

            double neededFuel = (distanceInKM / 100) * fuelPer100km;
            double fuelPrice = fuelPricePerLiter * neededFuel;
            double moneyLeft = profit - fuelPrice;

            if (profit < fuelPrice)
            {
                double profitPerPerson = profit / 5;

                Console.WriteLine("Sorry, you cannot go home. Each will receive {0:0.00} money.", profitPerPerson);
            }
            else if (profit >= fuelPrice)
            {
                Console.WriteLine("You can go home. {0:0.00} money left.", moneyLeft);
            }
        }
    }
}
