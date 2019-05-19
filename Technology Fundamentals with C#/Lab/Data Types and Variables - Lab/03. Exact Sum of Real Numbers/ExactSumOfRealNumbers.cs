namespace _03._Exact_Sum_of_Real_Numbers
{
    using System;

    class ExactSumOfRealNumbers
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
