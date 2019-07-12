namespace _02._Ascii_Sumator
{
    using System;

    public class AsciiSumator
    {
        public static void Main()
        {
            char to = char.Parse(Console.ReadLine());
            char from = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (from > text[i] && to < text[i])
                {
                    sum += text[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}