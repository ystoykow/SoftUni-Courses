using System;


namespace _01._Stadium_Income
{
    class StadiumIncome
    {
        static void Main()
        {

            int stadiumSectors = int.Parse(Console.ReadLine());
            int stadiumCap = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double oneSector = (stadiumCap * ticketPrice) / stadiumSectors;
            double totalincome = oneSector * stadiumSectors;
            double charity = (totalincome - (oneSector * 0.75)) / 8;

            Console.WriteLine(" Total income - {0:0.00} BGN", totalincome);
            Console.WriteLine("Money for charity - {0:0.00} BGN", charity);

        }

    }
}
