namespace _07.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int equalNumbers = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    if (count > bestLength)
                    {
                        bestLength = count;
                        equalNumbers = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(equalNumbers + " ");
            }
        }
    }
}
