namespace _04._Star_Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StarEnigma
    {
        public static void Main()
        {
            string pattern =
                @"@(?<name>([A-Z][a-z]+|[a-z]+))[^@\-!:>]*?:[^@\-!:>]*?(?<population>\d+)![^@\-!:>]*?(?<type>[AD])![^@\-!:>]*?->(?<soldiers>\d+)";
            char[] specialLetters = { 's', 't', 'a', 'r', 'S', 'T', 'A', 'R' };
            int countMessages = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < countMessages; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int countSpecialLetters = 0;

                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    if (specialLetters.Contains(encryptedMessage[j]))
                    {
                        countSpecialLetters++;
                    }
                }

                string decryptMessage = string.Empty;
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    decryptMessage += (char)((int)encryptedMessage[j] - countSpecialLetters);
                }

                if (Regex.IsMatch(decryptMessage, pattern))
                {
                    string planetName = Regex.Match(decryptMessage, pattern).Groups["name"].Value;
                    char type = char.Parse(Regex.Match(decryptMessage, pattern).Groups["type"].Value);
                    if (type == 'A' || type == 'a')
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
