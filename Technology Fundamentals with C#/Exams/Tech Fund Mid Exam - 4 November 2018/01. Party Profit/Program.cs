using System;

namespace _01._Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());
            double coins = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                bool IsPartyDay = false;
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                coins += 50 - (partySize * 2);
                if (i % 3 == 0)
                {
                    IsPartyDay = true;
                    coins -= 3 * partySize;
                }
                if(i%5==0)
                {
                    coins += 20 * partySize;
                    if (IsPartyDay)
                    {
                        coins -= 2 * partySize;
                    }
                }
            }
            Console.WriteLine($"{partySize} companions received {Math.Floor(coins/partySize)} coins each.");
        }
    }
}
