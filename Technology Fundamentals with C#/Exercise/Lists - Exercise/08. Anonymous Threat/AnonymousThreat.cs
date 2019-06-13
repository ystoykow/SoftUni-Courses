namespace _08._Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnonymousThreat
    {
        public static void Main()
        {
            List<string> texts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "3:1")
                {
                    break;
                }

                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);

                if (command[0] == "merge")
                {
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (startIndex > texts.Count - 1)
                    {
                        continue;
                    }

                    if (endIndex < 0)
                    {
                        continue;
                    }

                    if (endIndex > texts.Count - 1)
                    {
                        endIndex = texts.Count - 1;
                    }

                    string word = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        word += texts[i];
                    }

                    texts.RemoveRange(startIndex, endIndex - startIndex + 1);
                    texts.Insert(startIndex, word);

                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int parts = int.Parse(command[2]);
                    string word = texts[index];
                    List<string> dividedWords = new List<string>();
                    int partLength = word.Length / parts;
                    for (int i = 0; i < parts; i++)
                    {
                        string newWord = word.Substring(i * partLength, partLength);
                        if (i == parts - 1)
                        {
                            newWord = word.Substring(i * partLength);
                        }

                        dividedWords.Add(newWord);
                    }

                    texts.RemoveAt(index);
                    texts.InsertRange(index, dividedWords);
                }
            }

            Console.WriteLine(string.Join(" ", texts));
        }
    }
}
