using System;

namespace _03._Even_Powers_of_2
{
    class EvenPowersOf2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;

            for (int i = 0; i <= n; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(number);
                }

                number *= 2;
            }
        }
    }
}
