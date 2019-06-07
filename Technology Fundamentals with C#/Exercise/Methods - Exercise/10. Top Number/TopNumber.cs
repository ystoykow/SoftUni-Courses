namespace _10._Top_Number
{
    using System;

    public class TopNumber
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= inputNumber; i++)
            {
                bool result = IsSumOfDigitDividedByEight(i);

                if (result)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsSumOfDigitDividedByEight(int n)
        {
            bool result = false;
            bool haveOdd = false;
            int sumOfDigits = 0;
            
            while(n!=0)
            {
                int lastDigit = n % 10;
                if(lastDigit%2==1)
                {
                    haveOdd = true;
                }
                sumOfDigits += lastDigit;
                n /= 10;
            }
            if (haveOdd)
            {
                if (sumOfDigits % 8 == 0)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
