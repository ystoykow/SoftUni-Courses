namespace _05._Special_Numbers
{
    using System;

    class SpecialNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int sum = 0;

                while (currentNumber != 0)
                {
                    int lastDigit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += lastDigit;
                }

                if (sum ==5 || sum == 7|| sum ==11)
                {
                    Console.WriteLine($"{i} -> True");

                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
