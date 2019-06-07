namespace _01._Smallest_of_Three_Numbers
{
    using System;

    public class SmallestOfThreeNumbers
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumb(firstNumber, secondNumber, thirdNumber));
        }
        public static int SmallestNumb(int a, int b, int c)
        {
            int result;

            if (a < b && a < c)
            {
                result = a;
            }
            else if (b < a && b < c)
            {
                result = b;
            }
            else
            {
                result = c;
            }
            return result;
        }
    }
}
