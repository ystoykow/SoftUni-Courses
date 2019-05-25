namespace _02._Sum_Digits
{
    using System;

    class SumDigits
    {
        static void Main()
        {
            string numberAsText = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < numberAsText.Length; i++)
            {
                int currentNumber = (int)char.GetNumericValue(numberAsText[i]);
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
