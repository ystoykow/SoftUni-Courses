using System;

namespace _02._Wedding_Party
{
    class WeddingParty
    {
        static void Main()
        {
            double guests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double couvert = 20;
            double moneyNeeded = couvert * guests;
            double totalMoney = moneyNeeded - budget;

            if (budget >= moneyNeeded)
            {
                double moneyLeft = budget - moneyNeeded;
                double fireworks = moneyLeft * 0.4;
                double donation = moneyLeft - fireworks;

                Console.WriteLine("Yes! {0:0} lv are for fireworks and {1:0} lv are for donation.", fireworks, donation);
            }
            else
            {
                Console.WriteLine("They won't have enough money to pay the covert. They will need {0:0} lv more.", totalMoney);
            }
        }
    }
}
