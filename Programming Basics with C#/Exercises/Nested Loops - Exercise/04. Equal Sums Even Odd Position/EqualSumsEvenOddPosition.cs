using System;

namespace _04._Equal_Sums_Even_Odd_Position
{
    class EqualSumsEvenOddPosition
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string number = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    int currentNumber = int.Parse(number[j].ToString());

                    if (j%2==0)
                    {
                        evenSum += currentNumber;
                    }
                    else
                    {
                        oddSum += currentNumber;
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i +" ");
                }
            }
        }
    }
}
