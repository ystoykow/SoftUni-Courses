namespace _04._Mixed_up_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MixedUpLists
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mergedList = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                mergedList.Add(firstList[i]);
                mergedList.Add(secondList[secondList.Count - i - 1]);
            }

            int[] contains = new int[2];
            
            if (firstList.Count > secondList.Count)
            {
                contains[0] = firstList[firstList.Count - 1];
                contains[1] = firstList[firstList.Count - 2];
            }
            else
            {
                contains[0] = secondList[0];
                contains[1] = secondList[1];
            }

            int numberFrom = Math.Min(contains[0], contains[1]);
            int numberTo = Math.Max(contains[0], contains[1]);

            var result = mergedList.Where(x => x > numberFrom && x < numberTo).ToList();
            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
