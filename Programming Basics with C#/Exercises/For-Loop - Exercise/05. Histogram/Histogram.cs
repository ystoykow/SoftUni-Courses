using System;

namespace _05._Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOne = 0;
            int countTwo = 0;
            int countThree = 0;
            int countFour = 0;
            int countFive = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    countOne++;
                }
                else if (number >= 200 && number <= 399)
                {
                    countTwo++;
                }
                else if (number >= 400 && number <= 599)
                {
                    countThree++;
                }
                else if (number >= 600 && number <= 799)
                {
                    countFour++;
                }
                else
                {
                    countFive++;
                }
            }

            Console.WriteLine($"{countOne * 1.0 / n* 100:f2}%");
            Console.WriteLine($"{countTwo * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{countThree * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{countFour * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{countFive * 1.0 / n * 100:f2}%");
        }
    }
}
