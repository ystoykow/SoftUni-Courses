namespace _01._Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Messaging
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string text = Console.ReadLine();
            string result = string.Empty;

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                while (currentNumber != 0)
                {
                    int digit = currentNumber % 10;
                    sum += digit;
                    currentNumber /= 10;
                }

                if (text.Length < sum)
                {
                    while (sum>=text.Length)
                    {
                        sum -= text.Length;
                    }
                }

                result += text.Substring(sum, 1);
                text = text.Remove(sum, 1);
                sum = 0;
            }

            Console.WriteLine(result);
        }
    }
}
