namespace _04._Fold_and_Sum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = numbers.Length / 4;

            int[] first = new int[count];
            int[] middle = new int[count * 2];
            int[] last = new int[count];

            int lastCount = numbers.Length;

            for (int i = 0; i < count; i++)
            {
                first[i] = numbers[i];
                last[i] = numbers[lastCount - 1];
                lastCount--;
            }

            for (int i = 0; i < middle.Length; i++)
            {
                middle[i] = numbers[i + count];
            }

            Array.Reverse(first);
            int[] final = new int[first.Length + last.Length];

            int counter = 0;

            for (int i = 0; i < first.Length; i++)
            {
                final[i] = first[i];
                counter++;
            }

            for (int i = 0; i < last.Length; i++)
            {
                final[counter] = last[i];
                counter++;
            }

            int[] result = new int[middle.Length];

            for (int i = 0; i < middle.Length; i++)
            {
                result[i] = final[i] + middle[i];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
