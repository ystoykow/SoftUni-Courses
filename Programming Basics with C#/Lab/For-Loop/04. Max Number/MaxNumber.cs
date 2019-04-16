using System;

namespace _04._Max_Number
{
    class MaxNumber
    {
        static void Main()
        {
            int repeat = int.Parse(Console.ReadLine());

            int number = int.MinValue;

            for (int i = 0; i < repeat; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());

                if (newNumber > number)
                {
                    number = newNumber;
                }
            }

            Console.WriteLine(number);
        }
    }
}
