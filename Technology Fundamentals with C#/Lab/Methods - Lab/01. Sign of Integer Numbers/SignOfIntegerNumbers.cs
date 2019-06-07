namespace _01._Sign_of_Integer_Numbers
{
    using System;

    public class SignOfIntegerNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumber(number);
        }
        public static void PrintNumber(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
