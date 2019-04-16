using System;

namespace _08._Fishing
{
    class Fishing
    {
        static void Main()
        {
            int allFishes = int.Parse(Console.ReadLine());

            int counter = 0;
            int fishCounter = 0;
            double totalPay = 0;
            double totalWin = 0;

            while (true)
            {
                string fishName = Console.ReadLine();

                if (fishName=="Stop")
                {
                    break;
                }

                double fishKG = double.Parse(Console.ReadLine());

                fishCounter++;
                counter++;
                double fishPrice = 0;

                for (int i = 0; i < fishName.Length; i++)
                {
                    fishPrice += (int)fishName[i];
                }

                fishPrice = fishPrice / fishKG;

                if (fishCounter % 3 == 0)
                {
                    totalWin += fishPrice;
                }
                else
                {
                     totalPay += fishPrice;
                }

                if (allFishes==counter)
                {
                    Console.WriteLine($"Lyubo fulfilled the quota!");

                    break;
                }
            }

            if (totalWin>=totalPay)
            {
                Console.WriteLine($"Lyubo's profit from {fishCounter} fishes is {totalWin-totalPay:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {totalPay-totalWin:f2} leva today.");
            }
        }
    }
}
