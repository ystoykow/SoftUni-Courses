using System;

namespace _05._Min_Number
{
    class MinNumber
    {
        static void Main()
        {
            int repeat = int.Parse(Console.ReadLine());

            int number = int.MaxValue;

            for (int i = 0; i < repeat; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());

                if (newNumber < number)
                {
                    number = newNumber;
                }
            }

            Console.WriteLine(number);
        }
    }
}
