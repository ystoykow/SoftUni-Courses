using System;

namespace _07._Odd_Even_Sum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int odd = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i %2 ==0)
                {
                    odd += number;
                }
                else
                {
                    even += number;
                }
            }

            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(odd-even)}");
            }
        }
    }
}
