namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;

    public class CountCharsInString
    {
        public static void Main()
        {
            string[] texts = Console.ReadLine().Split(' ');
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            for (int i = 0; i < texts.Length; i++)
            {
                string word = texts[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (!countChars.ContainsKey(word[j]))
                    {
                        countChars.Add(word[j], 0);
                    }

                    countChars[word[j]]++;
                }
            }

            foreach (var ch in countChars)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}