namespace _03._Floating_Equality
{
    using System;

    class FloatingEquality
    {
        public static void Main()
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double absoluteNumberOne = Math.Abs(numberOne);
            double absoluteNumberTwo = Math.Abs(numberTwo);
            double eps = 0.000001;

            if (Math.Max(absoluteNumberOne, absoluteNumberTwo) - Math.Min(absoluteNumberOne,absoluteNumberTwo) > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
