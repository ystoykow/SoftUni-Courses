namespace _06._Replace_Repeating_Chars
{
    using System;

    public class ReplaceRepeatingChars
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    text = text.Remove(i, 1);
                    i = 0;
                }
            }

            Console.WriteLine(text);
        }
    }
}