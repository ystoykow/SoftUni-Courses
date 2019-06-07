using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosestToCenter(x1, y1, x2, y2);
        }
        static void PrintClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double numb1;
            double numb2;
            if (Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)) > Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)))
            {
                numb1 = x1;
                numb2 = y1;
            }
            else
            {
                numb1 = x2;
                numb2 = y2;
            }
            Console.WriteLine($"({numb1}, {numb2})");

        }
    }
}
