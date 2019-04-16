using System;

namespace _04._Equal_Pairs
{
    class EqualPairs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int maxDiff = int.MinValue;
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int currentNumber = firstNumber + secondNumber;

                if (i > 0)
                {
                    int differance = Math.Abs(currentNumber - sum);

                    if (differance >= maxDiff)
                    {
                        maxDiff = differance;
                    }
                }

                if (currentNumber==sum)
                {
                    counter++;
                }

                sum = currentNumber;
            }

            if (counter == n - 1) 
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}

