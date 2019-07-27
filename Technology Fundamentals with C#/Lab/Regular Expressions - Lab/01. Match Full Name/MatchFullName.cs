namespace _01._Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string text = Console.ReadLine();
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
        }
    }
}
