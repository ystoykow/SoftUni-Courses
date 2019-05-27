namespace _02._Pascal_Triangle
{
    using System;

    public class PascalTriangle
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[] numbers = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                numbers[i] = 1;
            }

            int[] secondNumbers = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                secondNumbers[i] = 1;
            }

            for (int i = 0; i < rows; i++)
            {
                if (i == 0)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + " ");
                }

                for (int j = 1; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        secondNumbers[j] = numbers[j] + numbers[j - 1];

                        Console.Write(secondNumbers[j] + " ");
                    }
                    else
                    {
                        numbers[j] = secondNumbers[j] + secondNumbers[j - 1];

                        Console.Write(numbers[j] + " ");
                    }
                }

                if (i >= 1)
                {
                    Console.WriteLine(numbers[numbers.Length - 1]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
