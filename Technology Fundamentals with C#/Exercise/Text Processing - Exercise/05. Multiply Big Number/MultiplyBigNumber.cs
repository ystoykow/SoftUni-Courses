namespace _05._Multiply_Big_Number
{
    using System;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            bool isZero = IsZero(firstNumber);
            int multiply = int.Parse(secondNumber);

            if (multiply != 0 && !isZero)
            {
                string result = string.Empty;
                int additional = 0;
                for (int i = firstNumber.Length - 1; i >= 0; i--)
                {
                    int number = (int)char.GetNumericValue(firstNumber[i]);
                    string currentResult = ((number * multiply) + additional).ToString();
                    if (currentResult.Length > 1)
                    {
                        string lastDigit = currentResult[1].ToString();
                        result = result.Insert(0, lastDigit);
                        additional = (int)char.GetNumericValue(currentResult[0]);
                    }
                    else
                    {
                        result = result.Insert(0, currentResult);
                        additional = 0;
                    }
                }

                if (additional != 0)
                {
                    result = result.Insert(0, additional.ToString());
                }

                while (result[0] == '0')
                {
                    result = result.Remove(0, 1);
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        public static bool IsZero(string firstNumber)
        {
            int countZeros = 0;
            for (int i = 0; i < firstNumber.Length; i++)
            {
                if (firstNumber[i] == '0')
                {
                    countZeros++;
                }
            }

            if (countZeros == firstNumber.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
