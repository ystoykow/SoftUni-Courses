namespace _02._Match_Phone_Number
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string pattern = @"\+[359]+( |-)[2]\1[0-9]{3}\1[0-9]{4}\b";
            string text = Console.ReadLine();
            var matches = Regex.Matches(text, pattern);
            var validMatches = matches.Cast<Match>().Select(m =>m.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ",validMatches));
        }
    }
}
