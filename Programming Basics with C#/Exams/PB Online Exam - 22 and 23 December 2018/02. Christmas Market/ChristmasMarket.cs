using System;

namespace _02._Christmas_Market
{
    class ChristmasMarket
    {
        static void Main()
        {
            double needMoney = double.Parse(Console.ReadLine());
            double fantasyCount = double.Parse(Console.ReadLine());
            double horrorCount = double.Parse(Console.ReadLine());
            double romanticCount = double.Parse(Console.ReadLine());
            double fantasyPrice = 14.90;
            double horrorPrice = 9.80;
            double romanticPrice = 4.30;
            double oookPrice = ((fantasyPrice * fantasyCount) + (horrorPrice * horrorCount) + (romanticPrice * romanticCount)) * 0.8;
            if (oookPrice >= needMoney)
            {
                double bonusMoney = oookPrice - needMoney;
                double reciveMoney = Math.Floor(bonusMoney * 0.1);
                double bonusDonation = bonusMoney - reciveMoney;
                double totalDonation = needMoney + bonusDonation;

                Console.WriteLine("{0:0.00} leva donated.", totalDonation);
                Console.WriteLine("Sellers will receive {0} leva.", reciveMoney);
            }
            else if (oookPrice < needMoney)
            {
                Console.WriteLine("{0:0.00} money needed.", needMoney - oookPrice);
            }
        }
    }
}
