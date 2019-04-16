using System;

namespace _04._Equal_Sums_Even_Odd_Position
{
    class EqualSumsLeftRightPosition
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int number = i;
                int leftSum = 0;
                int rightSum = 0;
                int d1 = number / 10000 % 10;
                int d2 = number / 1000 % 10;
                int d3 = number / 100 % 10;
                int d4 = number / 10 % 10;
                int d5 = number % 10;

                leftSum = d1 + d2;
                rightSum = d4 + d5;

                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
                else
                {

                    if (leftSum > rightSum)
                    {
                        rightSum += d3;

                        if (leftSum == rightSum)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    else if (rightSum > leftSum)
                    {
                        leftSum += d3;

                        if (leftSum == rightSum)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
        }
    }
}
