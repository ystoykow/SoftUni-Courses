namespace _04._Sum_of_Chars
{
    using System;

    class SumOfChars
    {
        static void Main()
        {
            int charsCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < charsCount; i++)
            {
                int currentChar = char.Parse(Console.ReadLine());
                sum += currentChar;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
