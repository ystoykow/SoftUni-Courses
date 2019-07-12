namespace _05._Word_Filter
{
    using System;

    public class WordFilter
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 == 0)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}