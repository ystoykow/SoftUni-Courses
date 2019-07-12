namespace _8._Letters_Change_Numbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                string numberAsText = word.Substring(1, word.Length - 2);
                double number = double.Parse(numberAsText);
                int indexOfLast = word.Length;
                double result;
                if (char.IsUpper(word[0]))
                {
                    int divider = word[0] - 64;
                    result = number / divider;
                }
                else
                {
                    int multiply = word[0] - 96;
                    result = number * multiply;
                }

                if (char.IsUpper(word[indexOfLast - 1]))
                {
                    int subtract = word[indexOfLast - 1] - 64;
                    result -= subtract;
                }
                else
                {
                    int add = word[indexOfLast - 1] - 96;
                    result += add;
                }

                sum += result;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}