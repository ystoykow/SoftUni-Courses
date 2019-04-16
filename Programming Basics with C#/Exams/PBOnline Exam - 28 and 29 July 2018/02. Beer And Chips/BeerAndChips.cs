using System;

namespace _02._Beer_And_Chips
{
    class BeerAndChips
    {
        static void Main()
        {
            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCont = int.Parse(Console.ReadLine());

            double beerSum = beerCount * 1.20;
            double chipsPrice = ((beerSum * 45) / 100);
            double chipsSum = Math.Ceiling(chipsPrice * chipsCont);
            double totalSum = chipsSum + beerSum;
            double budgetLeft = budget - totalSum;
            double neededBudget = totalSum - budget;

            if (budget >= totalSum)
            {
                Console.WriteLine("{0} bought a snack and has {1:0.00} leva left.", fanName, budgetLeft);
            }
            else
            {
                Console.WriteLine("{0} needs {1:0.00} more leva!", fanName, neededBudget);
            }
        }
    }
}
