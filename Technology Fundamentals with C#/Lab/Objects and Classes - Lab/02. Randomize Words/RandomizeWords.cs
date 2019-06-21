namespace _02._Randomize_Words
{
    using System;

    public class RandomizeWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);
                string currentWord = input[i];
                input[i] = input[randomIndex];
                input[randomIndex] = currentWord;
            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
