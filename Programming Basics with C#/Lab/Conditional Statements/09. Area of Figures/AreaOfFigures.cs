using System;

namespace _09._Area_of_Figures
{
    class AreaOfFigures
    {
        static void Main()
        {
            string type = Console.ReadLine();
            double area = 0;
            switch (type)
            {
                case "square":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        area = sideA * sideA;
                        break;
                    }
                case "rectangle":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        double sideB = double.Parse(Console.ReadLine());
                        area = sideA * sideB;
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        area = Math.PI * radius * radius;
                        break;
                    }
                case "triangle":
                    {
                        double higth = double.Parse(Console.ReadLine());
                        double sideA = double.Parse(Console.ReadLine());
                        area = sideA * higth / 2;
                        break;
                    }
                 default:
                    {
                        break;
                    }
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
