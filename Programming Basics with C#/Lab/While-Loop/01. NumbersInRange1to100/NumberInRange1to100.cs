using System;

namespace NumberInRange
{
    class NumberInRange1to100
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (number > 100 || number < 1)
            {
                Console.WriteLine("Invalid number!");

                number = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
