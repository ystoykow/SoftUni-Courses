namespace _06._Calculate_Rectangle_Area
{
    using System;

    public class CalculateRectangleArea
    {
        public static void Main()
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int area = GetTriangleArea(sideA, sideB);
            Console.WriteLine(area);
        }
        public static int GetTriangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
