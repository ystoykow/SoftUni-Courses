using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            while(input!="Stop")
            {
                string[] command = input.Split();
                if (command[0]=="Delete")
                {
                    if (words.Count>int.Parse(command[1])+1 && int.Parse(command[1])+1>=0)
                    {
                    words.RemoveAt(int.Parse(command[1]) + 1);
                    }
                }
                else if (command[0] == "Swap")
                {
                    string wordOne = command[1];
                    string wordTwo = command[2];
                    if (words.Contains(wordOne) && words.Contains(wordTwo))
                    {
                        int indexOfFirst = words.IndexOf(wordOne);
                        int indexOfSecond = words.IndexOf(wordTwo);
                        words.Insert(indexOfFirst, wordTwo);
                        words.RemoveAt(indexOfFirst + 1);
                        words.Insert(indexOfSecond, wordOne);
                        words.RemoveAt(indexOfSecond + 1);
                    }

                }
                else if (command[0] == "Put")
                {
                    if (0 <= int.Parse(command[2]) - 1 && int.Parse(command[2])-1<= words.Count)
                    {
                        words.Insert(int.Parse(command[2]) - 1, command[1]);
                    }
                }
                else if (command[0] == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (command[0] == "Replace")
                {
                    if (words.Contains(command[2]))
                    {
                        int indexOf = words.IndexOf(command[2]);
                        words.RemoveAt(indexOf);
                        words.Insert(indexOf, command[1]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',words));
        }
    }
}
