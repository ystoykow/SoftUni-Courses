namespace _3._Post_Office
{
    using System;
    using System.Text.RegularExpressions;

    public class PostOffice
    {
        public static void Main()
        {
            string capitalLettersPattern = @"([#$%*&])(?<capitals>[A-Z]+)\1";
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            Match capitalsMatch = Regex.Match(input[0], capitalLettersPattern);
            string capitals = capitalsMatch.Groups["capitals"].Value;
            for (int i = 0; i < capitals.Length; i++)
            {
                char currentChar = capitals[i];
                int charAsInt = currentChar;
                string asciiLengthPattern = $@"{charAsInt}:(?<length>[0-9][0-9])";
                Match lengthsMatch = Regex.Match(input[1], asciiLengthPattern);
                int length = int.Parse(lengthsMatch.Groups["length"].Value);
                string wordsPattern = $@"(?<=\s|^)[{currentChar}][^\s]{{{length}}}(?=\s|$)";
                string word = Regex.Match(input[2], wordsPattern).Value;
                Console.WriteLine(word);
            }
        }
    }
}
