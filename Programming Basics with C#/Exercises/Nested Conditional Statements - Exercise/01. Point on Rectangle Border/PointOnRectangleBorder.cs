using System;

namespace _01._Point_on_Rectangle_Border
{
    class PointOnRectangleBorder
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool borderX = false;
            bool borderY = false;

            if (x == x1 || x == x2)
            {
                if (y >= y1 && y <= y2)
                {
                    borderX = true;
                }
            }
            else if (y == y1 || y == y2)
            {
                if (x >= x1 && x <= x2)
                {
                    borderY = true;
                }
            }

            if (borderX || borderY)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
