namespace _03._Recursive_Fibonacci
{
    using System;

    public class RecursiveFibonacci
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            ulong firstNumber = 0;
            ulong secondNumber = 1;
            ulong thirdNumber = 0;
            {
                for (int i = 0; i < number; i++)
                {
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = firstNumber + secondNumber;
                }
            }

            Console.Write("{0}", thirdNumber);
        }
    }
}
