using System;

namespace _02._Maiden_Party
{
    class MaidenParty
    {
        static void Main()
        {
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            double loveMessageCount = double.Parse(Console.ReadLine());
            double rosesCount = double.Parse(Console.ReadLine());
            double keychainCount = double.Parse(Console.ReadLine());
            double cartoonCount = double.Parse(Console.ReadLine());
            double luckySurpriseCount = double.Parse(Console.ReadLine());

            if (cartoonCount + keychainCount + loveMessageCount + luckySurpriseCount + rosesCount >= 25)
            {
                double totalIncome = (loveMessageCount * 0.60) + (rosesCount * 7.20) + (keychainCount * 3.60) + (cartoonCount * 18.20) + (luckySurpriseCount * 22);
                double discount = totalIncome * 0.65;
                double hosting = discount * 0.9;

                if (hosting >= maidenPartyPrice)
                {
                    Console.WriteLine("Yes! {0:0.00} lv left.", hosting - maidenPartyPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! {0:0.00} lv needed.", maidenPartyPrice - hosting);
                }
            }
            else
            {
                double totalincome = (loveMessageCount * 0.60) + (rosesCount * 7.20) + (keychainCount * 3.60) + (cartoonCount * 18.20) + (luckySurpriseCount * 22);
                double hosting = totalincome * 0.9;

                if (maidenPartyPrice < hosting)
                {
                    Console.WriteLine("Yes! {0:0.00} lv left.", hosting - maidenPartyPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! {0:0.00} lv needed.", maidenPartyPrice - hosting);
                }
            }
        }
    }
}
