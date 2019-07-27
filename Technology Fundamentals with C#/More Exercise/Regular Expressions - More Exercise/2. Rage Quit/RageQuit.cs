using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Rage_Quit
{
    public class RageQuit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            StringBuilder text = new StringBuilder();
            List<char> uniqueSymbols = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    string repeat = string.Empty;
                    for (int j = i; j < input.Length; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            repeat += input[j];
                            i++;
                        }
                        else
                        {
                            i--;
                            break;
                        }
                    }

                    int countWord = int.Parse(repeat);
                    for (int j = 0; j < countWord; j++)
                    {
                        result.Append(text);
                    }

                    text.Clear();
                }
                else
                {
                    text.Append(input[i]);
                }
            }

            string finalResult = result.ToString().ToUpper();
            for (int i = 0; i < finalResult.Length; i++)
            {
                if (!uniqueSymbols.Contains(finalResult[i]))
                {
                    uniqueSymbols.Add(finalResult[i]);
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(finalResult);
        }
    }
}