using System;

namespace EvenOrOdd_Position
{
    class EvenOrOddPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            int counterOdd = 0;
            int counterEven = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    counterEven++;
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    counterOdd++;
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
            }

            Console.Write($"OddSum={oddSum}, ");

            if (counterOdd == 0)
            {
                Console.Write("OddMin=No, ");
                Console.Write("OddMax=No, ");
            }
            else
            {
                Console.Write($"OddMin={oddMin}, ");
                Console.Write($"OddMax={oddMax}, ");
            }

            Console.Write($"EvenSum={evenSum}, ");

            if (counterEven == 0)
            {
                Console.Write("EvenMin=No, ");
                Console.Write("EvenMax=No");
            }
            else
            {
                Console.Write($"EvenMin={evenMin}, ");
                Console.Write($"EvenMax={ evenMax}");
            }
        }
    }
}
