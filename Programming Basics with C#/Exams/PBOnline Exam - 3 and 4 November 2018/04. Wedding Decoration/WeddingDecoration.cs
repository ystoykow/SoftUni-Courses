using System;

namespace _04._Wedding_Decoration
{
    class WeddingDecoration
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int totalBallons = 0;
            int totalRibbons = 0;
            int totalCandles = 0;
            int totalFlowers = 0;
            double totalSum = 0;
            while (command != "stop")
            {
                string item = command;
                command = Console.ReadLine();

                int number = int.Parse(command);

                if (item == "balloons")
                {
                    totalSum += number * 0.1;
                    totalBallons += number;
                }
                else if (item == "ribbon")
                {
                    totalSum += number * 2;
                    totalRibbons += number;
                }
                else if (item == "candles")
                {
                    totalSum += number * 0.5;
                    totalCandles += number;
                }
                else if (item == "flowers")
                {
                    totalSum += number * 1.5;
                    totalFlowers += number;
                }

                if (totalSum >= budget)
                {
                    Console.WriteLine("All money is spent!");
                    Console.WriteLine("Purchased decoration is {0} balloons, {1} m ribbon, {2} flowers and {3} candles.", totalBallons, totalRibbons, totalFlowers, totalCandles);

                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Spend money: {0:0.00}", totalSum);
            Console.WriteLine("Money left: {0:0.00}", budget - totalSum);
            Console.WriteLine("Purchased decoration is {0} balloons, {1} m ribbon, {2} flowers and {3} candles.", totalBallons, totalRibbons, totalFlowers, totalCandles);
        }
    }
}
