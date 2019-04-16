using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string pattern = @"^[d-z{}|#]+$";
            string input = Console.ReadLine();
            string[] replacements = Console.ReadLine().Split();
            bool isValid = Regex.IsMatch(input, pattern);
            if(isValid)
            {
                sb.Append(input);
                for (int i = 0; i < sb.Length; i++)
                {
                    int currentChar = (int)sb[i];
                    int newChar = currentChar - 3;
                    sb[i] = (char)newChar;
                }
                sb.Replace(replacements[0], replacements[1]);
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
