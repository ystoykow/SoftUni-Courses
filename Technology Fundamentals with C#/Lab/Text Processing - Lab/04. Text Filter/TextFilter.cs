namespace _04._Text_Filter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            string[] banWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < banWords.Length; i++)
            {
                text = text.Replace(banWords[i], new string('*', banWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}