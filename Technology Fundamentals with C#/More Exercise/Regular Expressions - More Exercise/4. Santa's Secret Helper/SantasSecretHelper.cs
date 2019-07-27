namespace _4._Santa_s_Secret_Helper
{
    using System;
    using System.Text.RegularExpressions;

    public class SantasSecretHelper
    {
        public static void Main()
        {
            int decryptKey = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<type>[Gg]|[Nn])!";
            while (input != "end")
            {
                string decryptedMessage = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    char decryptChar = (char)(input[i] - decryptKey);
                    decryptedMessage += decryptChar;
                }

                if (Regex.IsMatch(decryptedMessage, pattern))
                {
                    Match currentChild = Regex.Match(decryptedMessage, pattern);
                    string childName = currentChild.Groups["name"].Value;
                    char childType = char.Parse(currentChild.Groups["type"].Value);
                    if (childType == 'G' || childType == 'g')
                    {
                        Console.WriteLine(childName);
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
