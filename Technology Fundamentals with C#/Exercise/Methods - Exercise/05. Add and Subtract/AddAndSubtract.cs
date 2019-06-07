namespace _05._Add_and_Subtract
{
    using System;

    public class AddAndSubtract
    {
        public static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Subtract(numberOne, numberTwo, numberThree));
        }
        public static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public static int Subtract(int a, int b,int c)
        {
            int result = Sum(a, b) - c;
            return result;
        }
    }
}
