namespace _01._Animal_Sanctuary
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class AnimalSanctuary
    {
        public static void Main()
        {
            string pattern = @"^n:(?<name>[^;]+);t:(?<type>[^;]+);c--(?<country>[A-Za-z\s]+)$";

            int count = int.Parse(Console.ReadLine());
            int weight = 0;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input,pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var animal = new List<string>();
                    animal.Add(match.Groups[1].Value);
                    animal.Add(match.Groups[2].Value);
                    animal.Add(match.Groups[3].Value);

                    for (int j = 0; j < animal.Count; j++)
                    {
                        string item = animal[j];
                        string newItem = string.Empty;
                        for (int k = 0; k < item.Length; k++)
                        {

                            if(char.IsWhiteSpace(item[k])
                                || char.IsLetter(item[k]))
                            {
                                newItem += item[k];


                            }
                            else if (char.IsDigit(item[k]))
                            {

                                weight += (int)char.GetNumericValue(item[k]);
                            }

                        }
                        animal[j] = newItem;
                    }
                    Console.WriteLine($"{animal[0]} is a {animal[1]} from {animal[2]}");
                }
            }
            Console.WriteLine($"Total weight of animals: {weight}KG");
        }
    }
}
