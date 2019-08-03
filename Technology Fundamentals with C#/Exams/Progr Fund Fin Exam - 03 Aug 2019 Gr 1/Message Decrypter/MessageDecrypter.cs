namespace Message_Decrypter
{
    using System;
    using System.Text.RegularExpressions;

    public class MessageDecrypter
    {
        public static void Main()
        {
            string pattern = @"^([$%])(?<name>[A-Z][a-z]{2,})\1: \[(?<firstNumber>[0-9]+)\]\|\[(?<secondNumber>[0-9]+)\]\|\[(?<thirdNumber>[0-9]+)\]\|$";
            int countOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfInputs; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    string name = Regex.Match(input, pattern).Groups["name"].Value;
                    int firstCharAsInt = int.Parse(Regex.Match(input, pattern).Groups["firstNumber"].Value);
                    int secondCharAsInt = int.Parse(Regex.Match(input, pattern).Groups["secondNumber"].Value);
                    int thirdCharAsInt = int.Parse(Regex.Match(input, pattern).Groups["thirdNumber"].Value);
                    char first = (char)firstCharAsInt;
                    char second = (char)secondCharAsInt;
                    char third = (char)thirdCharAsInt;
                    Console.WriteLine($"{name}: {first}{second}{third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
