namespace _03._Calculations
{
    using System;

    public class Calculations
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            MakeCalc(command, numberOne, numberTwo);
        }
        public static void MakeCalc(string command, int a ,int b)
        {
            if (command=="add")
            {
                Console.WriteLine(a+b);
            }
            else if (command == "multiply")
            {
                Console.WriteLine(a*b);
            }
            else if (command == "subtract")
            {
                Console.WriteLine(a-b);
            }
            else if (command == "divide")
            {
                Console.WriteLine(a/b);
            }
        }
    }
}
