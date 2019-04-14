using System;
namespace _03._2D_Rectangle_Area
{
    class RectangleArea2D
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);
            double area = sideA * sideB;
            double perimeter = 2 * (sideA + sideB);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
