namespace _01._The_Isle_of_Man_TTRace
{
    using System;
    using System.Text.RegularExpressions;

    public class TheIsleOfManTTRace
    {
        public static void Main()
        {
            string pattern = @"^(?<name>[#$%*&][A-Za-z]+[#$%*&])=(?<lenght>[0-9]+)!!(?<text>[!-~]+)$";
            string input = Console.ReadLine();
            bool isFound = false;
            while (true)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string name = match.Groups[1].Value;
                    int lenght = int.Parse(match.Groups[2].Value);
                    string text = match.Groups[3].Value;

                    if (name[0].Equals(name[name.Length - 1]))
                    {
                        name = name.Substring(1, name.Length - 2);
                        if (lenght == text.Length)
                        {
                            isFound = true;

                            string newText = string.Empty;

                            for (int i = 0; i < text.Length; i++)
                            {
                                int ch = text[i] + lenght;
                                newText += (char)ch;
                            }

                            text = newText;
                        }
                    }
                    if (isFound)
                    {
                        Console.WriteLine($"Coordinates found! {name} -> {text}");
                        break;
                    }

                }

                Console.WriteLine("Nothing found!");

                input = Console.ReadLine();
            }
        }
    }
}
