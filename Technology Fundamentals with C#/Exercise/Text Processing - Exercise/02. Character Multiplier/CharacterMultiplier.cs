namespace _02._Character_Multiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];
            int sum = 0;

            if (firstWord.Length > secondWord.Length)
            {
                sum += SumStrings(firstWord, secondWord);
            }
            else
            {
                sum += SumStrings(secondWord, firstWord);
            }

            Console.WriteLine(sum);
        }

        public static int SumStrings(string longestString, string shortedString)
        {
            int sum = 0;
            for (int i = 0; i < longestString.Length; i++)
            {
                if (i < shortedString.Length)
                {
                    sum += shortedString[i] * longestString[i];
                }
                else
                {
                    sum += longestString[i];
                }
            }

            return sum;
        }
    }
}