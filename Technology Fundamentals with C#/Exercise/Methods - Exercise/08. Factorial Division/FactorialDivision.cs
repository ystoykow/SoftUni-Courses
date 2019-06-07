namespace _08._Factorial_Division
{
    using System;

    public class FactorialDivision
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = DivideFactorial(firstNumber, secondNumber);

            Console.WriteLine($"{result:f2}");
        }
        public static double GetFactorial(double n)
        {
            double num = n;
            double fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }
        public static double DivideFactorial(double a, double b)
        {
            double first = GetFactorial(a);
            double second = GetFactorial(b);

            double result = first / second;

            return result;
        }
    }
}
