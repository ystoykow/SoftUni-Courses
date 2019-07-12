namespace _03._Substring
{
    using System;

    public class Substring
    {
        public static void Main()
        {
            string wordToDel = Console.ReadLine().ToLower();
            string text = Console.ReadLine();
            while (true)
            {
                int index = text.IndexOf(wordToDel);
                if (index == -1)
                {
                    break;
                }

                text = text.Remove(index, wordToDel.Length);
            }

            Console.WriteLine(text);
        }
    }
}