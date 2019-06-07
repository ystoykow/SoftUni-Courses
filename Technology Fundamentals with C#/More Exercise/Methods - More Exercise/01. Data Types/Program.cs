using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input=="int")
            {
                PrintInput(int.Parse(Console.ReadLine()));
            }
            else if (input=="real")
            {
                PrintInput(double.Parse(Console.ReadLine()));
            }
            else
            {
                PrintInput(Console.ReadLine());
            }
           
        }
        static void PrintInput(int n)
        {
            Console.WriteLine(n * 2);
        }
        static void PrintInput(double n)
        {
            Console.WriteLine($"{n * 1.5:f2}");
        }
        static void PrintInput(string n)
        {
            Console.WriteLine($"${n}$");
        }
    }
}
