using System;
using System.Text.RegularExpressions;

namespace _03._The_Isle_of_Man_TT_Race
{
   public class TheIsleOfManTTRace
    {
       public static void Main()
        {
            string pattern = @"([#$%*&])(?<name>[A-Za-z]+)\1=(?<geoHash>[0-9]+)!!(?<encrypt>.+)";
            bool isFound = false;
            while (!isFound)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    Match currentMatch = Regex.Match(input, pattern);
                    string name = currentMatch.Groups["name"].Value;
                    int geoHashLength = int.Parse(currentMatch.Groups["geoHash"].Value);
                    string encryptMessage = currentMatch.Groups["encrypt"].Value;
                    if (encryptMessage.Length == geoHashLength)
                    {
                        string result = string.Empty;
                        for (int i = 0; i < geoHashLength; i++)
                        {
                            result += (char)(encryptMessage[i] + geoHashLength);
                        }

                        Console.WriteLine($"Coordinates found! {name} -> {result}");
                        isFound = true;
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
            }
        }
    }
}
