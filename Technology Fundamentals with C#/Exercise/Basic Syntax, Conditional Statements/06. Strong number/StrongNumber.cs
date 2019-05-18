namespace _06._Strong_number
{
    using System;

    class StrongNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = (int)char.GetNumericValue(input[i]);
                int factorial = 1;
                for (int j = 1; j <= currentNumber; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
