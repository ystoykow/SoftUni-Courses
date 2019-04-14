using System;

namespace _06.Circle_Area_and_Perimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimetar = 2 * Math.PI * r;
            Console.WriteLine("{0:0.00}", area);
            Console.WriteLine("{0:0.00}", perimetar);
        }
    }
}
