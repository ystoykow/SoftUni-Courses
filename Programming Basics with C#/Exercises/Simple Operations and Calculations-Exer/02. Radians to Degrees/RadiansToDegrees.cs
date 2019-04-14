using System;
namespace _02.Radians_to_Degrees
{
    class RadiansToDegrees
    {
        static void Main()
        {
            double radians = double.Parse(Console.ReadLine());

            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
