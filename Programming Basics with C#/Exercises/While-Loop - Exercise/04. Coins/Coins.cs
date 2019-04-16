using System;

namespace _04._Coins
{
    class Coins
    {
        static void Main()
        {
            decimal price = decimal.Parse(Console.ReadLine());

            decimal coinPrice = price * 100;
            int count = 0;

            while (coinPrice >= 200)
            {
                coinPrice -= 200m;
                count++;
            }

            while (coinPrice >= 100)
            {
                coinPrice -= 100m;
                count++;
            }

            while (coinPrice >= 50)
            {
                coinPrice -= 50m;
                count++;
            }

            while (coinPrice >= 20)
            {
                coinPrice -= 20m;
                count++;
            }

            while (coinPrice >= 10)
            {
                coinPrice -= 10m;
                count++;
            }

            while (coinPrice >= 5)
            {
                coinPrice -= 5m;
                count++;
            }

            while (coinPrice >= 2)
            {
                coinPrice -= 2m;
                count++;
            }

            while (coinPrice >= 1)
            {
                coinPrice -= 1m;
                count++;
            }

                Console.WriteLine(count);
        }
    }
}

