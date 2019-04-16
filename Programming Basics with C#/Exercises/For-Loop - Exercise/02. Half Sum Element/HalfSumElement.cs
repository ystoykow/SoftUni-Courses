using System;

namespace _02._Half_Sum_Element
{
    class HalfSumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int biggest = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number>biggest)
                {
                    biggest = number;
                }

                sum += number;
            }

            if ((sum-biggest)== biggest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggest}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(biggest - (sum-biggest))}");
            }
        }
    }
}
