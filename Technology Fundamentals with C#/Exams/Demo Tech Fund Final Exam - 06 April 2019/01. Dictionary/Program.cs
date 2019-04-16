using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" | ");
            SortedDictionary<string, List<string>> dict = new SortedDictionary<string, List<string>>();
            for (int i = 0; i < words.Length; i++)
            {
                string[] currentText = words[i].Split(": ");
                string key = currentText[0];
                string word = currentText[1];
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>());
                }
                    dict[key].Add(word);
                
            }

            string[] wordsToShow = Console.ReadLine().Split(" | ");

            for (int i = 0; i < wordsToShow.Length; i++)
            {
                if (dict.ContainsKey(wordsToShow[i]))
                {
                    foreach (var mainWord in dict.Where(w=>w.Key==wordsToShow[i]))
                    {
                        Console.WriteLine($"{mainWord.Key}");
                        foreach (var w in mainWord.Value.OrderByDescending(x=>x.Length))
                        {
                            Console.WriteLine($" -{w}");
                        }
                    }
                }
            }
            string lastCommand = Console.ReadLine();
            if (lastCommand=="List")
            {
                Console.WriteLine(string.Join(" ",dict.Keys));
            }
        }
    }
}
