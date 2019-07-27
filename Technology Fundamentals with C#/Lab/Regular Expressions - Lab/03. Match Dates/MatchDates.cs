namespace _03._Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            string pattern = @"\b(?<day>[0-9]{2})([-\/\.])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            string text = Console.ReadLine();
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
