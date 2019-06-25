namespace Party_Profit
{
    using System;

    public class PartyProfit
    {
        public static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;
            for (int day = 1; day <= days; day++)
            {
                if (day % 15 == 0)
                {
                    partySize += 5;
                }

                if (day % 10 == 0)
                {
                    partySize -= 2;
                }

                bool haveMotivationParty = false;
                coins += 50;
                coins -= 2 * partySize;
                if (day % 3 == 0)
                {
                    coins -= 3 * partySize;
                    haveMotivationParty = true;
                }

                if (day % 5 == 0)
                {
                    coins += 20 * partySize;
                    if (haveMotivationParty)
                    {
                        coins -= 2 * partySize;
                    }
                }
            }

            int coinsPerCompanion =( coins / partySize);

            Console.WriteLine($"{partySize} companions received {coinsPerCompanion} coins each.");
        }
    }
}
