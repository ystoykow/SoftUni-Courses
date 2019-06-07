namespace _06._Middle_Characters
{
    using System;

    public class MiddleCharacters
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            Console.WriteLine(GetMiddleChar(text));

        }
        public static string GetMiddleChar(string text)
        {
            string result = string.Empty;

            if (text.Length % 2 == 0)
            {
                int numOfChar = text.Length / 2;

                result += text[numOfChar - 1];
                result += text[numOfChar];
            }
            else
            {
                int numOfChar = text.Length / 2;
                result += text[numOfChar];
            }

            return result;
        }
    }
}
