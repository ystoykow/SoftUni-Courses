using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=[\s])(?<emoji>:[a-z]{4,}:)(?=[\s,.!?])";
            string text = Console.ReadLine();
            int[] code = Console.ReadLine().Split(':',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sumEmoji = 0;
            var matches = Regex.Matches(text, pattern);
            var matchList = matches.ToList();
            var finalMatchs = new List<string>();
            for (int i = 0; i < matchList.Count; i++)
            {
                string currentMatch = matchList[i].ToString();
                finalMatchs.Add(currentMatch);

                for (int j = 1; j < currentMatch.Length-1; j++)
                {
                    sumEmoji += currentMatch[j];
                }
            }
            string codeAsText = string.Empty;

            for (int i = 0; i < code.Length; i++)
            {
                codeAsText += (char)code[i];
            }
            if (finalMatchs.Contains(':'+codeAsText+':'))
            {
                sumEmoji *= 2;
            }
            if (finalMatchs.Count > 0)
            {
                Console.WriteLine($"Emojis found: {string.Join(", ", finalMatchs)}");
            }

            Console.WriteLine($"Total Emoji Power: {sumEmoji}");
        }
    }
}
