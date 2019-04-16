using System;

namespace _03._Sum_Numbers
{
    class SumNumbers
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
               
            }

            Console.WriteLine(sum);
        } 
    }
}
