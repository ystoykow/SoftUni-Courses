namespace _10._Multiply_Evens_by_Odds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetMultipleOfEvenAndOdd(number));
        }
        public static int GetSumOfDigits(int numb, int expectedRemainder)
        {
            int n = Math.Abs(numb);
            int result = 0;
            
            while (n != 0)
            {
                int lastDigit = n % 10;

                if (lastDigit % 2 == expectedRemainder)
                {
                    result += lastDigit;
                }

                n /= 10;
            }

            return result;
        }
        public static int GetSumOfOddDigits(int numb)
        {
            return GetSumOfDigits(numb, 1);

        }
        public static int GetSumOfEvenDigits(int numb)
        {
            return GetSumOfDigits(numb, 0);

        }
        public static int GetMultipleOfEvenAndOdd(int numb)
        {
            return GetSumOfEvenDigits(numb) * GetSumOfOddDigits(numb);
        }
    }
}
