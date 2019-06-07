namespace _08._Math_Power
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double powerOfNum = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Power(number, powerOfNum));
        }
        public static double Power(double num, double pow)
        {
            double number = num;

            for (int i = 1; i < pow; i++)
            {
                number *= num;
            }

            return number;
        }
    }
}
