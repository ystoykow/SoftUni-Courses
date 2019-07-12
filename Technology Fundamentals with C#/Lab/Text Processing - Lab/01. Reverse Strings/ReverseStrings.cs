namespace _01._Reverse_Strings
{
    using System;

    public class ReverseStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string newWord = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    newWord += input[i];
                }

                Console.WriteLine($"{input} = {newWord}");
                input = Console.ReadLine();
            }
        }
    }
}