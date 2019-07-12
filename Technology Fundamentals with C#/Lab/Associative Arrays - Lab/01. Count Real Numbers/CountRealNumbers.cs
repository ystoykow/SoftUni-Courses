namespace _01._Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> countedNumbers = new SortedDictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!countedNumbers.ContainsKey(numbers[i]))
                {
                    countedNumbers.Add(numbers[i], 0);
                }

                countedNumbers[numbers[i]]++;
            }

            foreach (var kvp in countedNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}