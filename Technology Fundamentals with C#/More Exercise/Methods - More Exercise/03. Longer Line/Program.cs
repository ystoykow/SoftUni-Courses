using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double lineOne = CalcLineLong(x1,y1,x2,y2);
            double lineTwo = CalcLineLong(x3,y3,x4,y4);
            if (lineOne>lineTwo)
            {
                PrintClosestToCenter(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestToCenter(x3, y3, x4, y4);
            }
        }
        static double CalcLineLong(double x1, double y1, double x2, double y2)
        {
            double lane = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) + Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            return lane;
        }
        static void PrintClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double numb1;
            double numb2;
            double numb3;
            double numb4;
            if (Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)) >= Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)))
            {
                numb1 = x1;
                numb2 = y1;
                numb3 = x2;
                numb4 = y2;
            }
            else
            {
                numb1 = x2;
                numb2 = y2;
                numb3 = x1;
                numb4 = y1;
            }
            Console.WriteLine($"({numb1}, {numb2})({numb3}, {numb4})");

        }
    }
}
