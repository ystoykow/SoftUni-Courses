namespace _11._Math_operations
{
    using System;

    public class MathOperations
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calc(number, oper, secondNumber);
            Console.WriteLine(result);

        }
        public static double Calc(int numbOne, char oper, int numbTwo)
        {
            double result = 0;
            switch (oper)
            {
                case '+':
                    result = numbOne + numbTwo;
                    break;

                case '-':
                    result = numbOne - numbTwo;
                    break;
                case '*':
                    result = numbOne * numbTwo;
                    break;
                case '/':
                    result = numbOne / numbTwo;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
