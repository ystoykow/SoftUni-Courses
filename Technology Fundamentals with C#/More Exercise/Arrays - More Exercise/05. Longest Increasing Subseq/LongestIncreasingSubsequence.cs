namespace _05._Longest_Increasing_Subseq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSubsequence
    {
       public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> lis = new List<int>();


            int[] len = new int[numbers.Length];
            int[] prev = new int[numbers.Length];

            int maxLen = 0;
            int maxIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                prev[i] = -1;
                len[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i]>numbers[j] && len[j] +1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                        
                    }
                    if(len[i]> maxLen)
                    {
                        maxLen = len[i];
                        maxIndex = i;
                    }
                }
            } 
            while(maxIndex>=0)
            {
                lis.Add(numbers[maxIndex]);
                maxIndex = prev[maxIndex];
            }

            lis.Reverse();

            Console.WriteLine(string.Join(" ",lis));
        }
    }
}
