namespace _01._Arriving_in_Kathmandu
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ArrivingInKathmandu
    {
        public static void Main()
        {
            string pattern = @"^(?<name>[A-Za-z!@#$?0-9]+)=(?<lenght>[0-9]+)<<(?<msg>[A-z0-9]+$)";

            string input = Console.ReadLine();

            while (input != "Last note")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string name = match.Groups[1].Value;
                    int lenght = int.Parse(match.Groups[2].Value);
                    string text = match.Groups[3].Value;

                    if (text.Length == lenght)
                    {
                        string fullName = string.Empty;
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (char.IsLetterOrDigit(name[i]))
                            {
                                fullName += name[i];
                            }
                        }

                        Console.WriteLine($"Coordinates found! {fullName} -> {text}");
                    }
                    else
                    {
                        Console.WriteLine($"Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine($"Nothing found!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
