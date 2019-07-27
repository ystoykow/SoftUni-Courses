namespace _06._Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string pattern =
                @"((?<=\s)[a-zA-Z0-9]+([-_.][a-zA-Z0-9]+|[a-zA-Z0-9]*)*@[a-zA-Z]+?([.-][a-zA-Z]+)*(\.[A-Za-z]+([.-][a-zA-Z]+)*))";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
