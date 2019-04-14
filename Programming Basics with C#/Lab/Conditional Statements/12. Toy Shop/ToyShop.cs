using System;

namespace _12._Toy_Shop
{
    class ToyShop
    {
        static void Main()
        {
            double rest = double.Parse(Console.ReadLine());
            int countPuzzels = int.Parse(Console.ReadLine());
            int countTalkDoll = int.Parse(Console.ReadLine());
            int countTedyBear = int.Parse(Console.ReadLine());
            int countMinion = int.Parse(Console.ReadLine());
            int countTruck = int.Parse(Console.ReadLine());

            int totaltoys = countMinion + countPuzzels + countTalkDoll + countTedyBear + countTruck;
            double puzzelPrice = countPuzzels * 2.60;
            double talkDollPrice = countTalkDoll * 3;
            double tedyBearPrice = countTedyBear * 4.1;
            double minionPrice = countMinion * 8.2;
            double truckPrice = countTruck * 2;
            double totalPrice = puzzelPrice + talkDollPrice + tedyBearPrice + minionPrice + truckPrice;

            if (totaltoys>= 50)
            {
                totalPrice *= 0.75;
                
            }

            totalPrice -= totalPrice * 0.1;

            if (totalPrice >=rest )
            {
                Console.WriteLine($"Yes! {totalPrice-rest:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {rest-totalPrice:f2} lv needed.");
            }
        }
    }
}
