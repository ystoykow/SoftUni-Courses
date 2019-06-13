namespace _03._Merging_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MergingLists
    {
        public static void Main()
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = Merge(listOne, listTwo);

            Console.WriteLine(string.Join(" ", result));
        }
        public static List<int> Merge(List<int> first, List<int> second)
        {
            List<int> result = new List<int>();
            int count = 0;
            int biggestList = Math.Max(first.Count, second.Count);
            int smallestList = Math.Min(first.Count, second.Count);

            for (int i = 0; i < smallestList; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
                count++;
            }

            for (int i = count; i < biggestList; i++)
            {
                if (first.Count > second.Count)
                {
                    result.Add(first[i]);
                }
                else
                {
                    result.Add(second[i]);
                }
            }

            return result;
        }
    }
}
