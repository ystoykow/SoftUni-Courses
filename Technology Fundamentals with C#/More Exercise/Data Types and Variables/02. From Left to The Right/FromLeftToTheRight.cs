namespace _02._From_Left_to_The_Right
{
    using System;
    using System.Linq;

    class FromLeftToTheRight
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (numbers[0] > numbers[1])
                {
                    long result = Sum(numbers[0]);
                    Console.WriteLine(result);
                }
                else
                { 
                    long result = Sum(numbers[1]);
                    Console.WriteLine(result);
                }
            }
        }

        private static long Sum(long array)
        {
            long currentNumber = array;
            long sum = 0;
            while (currentNumber != 0)
            {
                sum += currentNumber % 10;
                currentNumber /= 10;
            }
            return Math.Abs(sum);
        }
    }
}

