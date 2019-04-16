using System;

namespace _05._Histogram
{
    class DivideWithoutRemainder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOne = 0;
            int countTwo = 0;
            int countThree = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    countOne++;
                }
                if (number % 3 == 0)
                {
                    countTwo++;
                }
                if (number % 4 == 0)
                {
                    countThree++;
                }
            }

            Console.WriteLine($"{countOne * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{countTwo * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{countThree * 1.0 / n * 100:f2}%");
        }
    }
}
