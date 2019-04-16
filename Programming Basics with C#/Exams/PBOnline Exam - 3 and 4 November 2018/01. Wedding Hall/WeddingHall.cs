using System;

namespace _01._Wedding_Hall
{
    class WeddingHall
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double barSide = double.Parse(Console.ReadLine());

            double spacePerPerson = 3.2;
            double totalSpace = length * width;
            double barSpace = barSide * barSide;
            double dancingSpace = totalSpace * 0.19;
            double freeSpace = totalSpace - barSpace - dancingSpace;
            double guests = freeSpace / spacePerPerson;

            Console.WriteLine("{0}", Math.Ceiling(guests));
        }
    }
}
