namespace _02._Repeat_Strings
{
    using System;

    public class RepeatStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int count = input.Length;
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    result += input[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}