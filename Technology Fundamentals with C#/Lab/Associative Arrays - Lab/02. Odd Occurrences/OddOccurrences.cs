namespace _02._Odd_Occurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!wordsCount.ContainsKey(words[i]))
                {
                    wordsCount.Add(words[i], 0);
                }

                wordsCount[words[i]]++;
            }

            var results = wordsCount.Where(x => x.Value % 2 == 1);

            foreach (var result in results)
            {
                Console.Write($"{result.Key} ");
            }
        }
    }
}