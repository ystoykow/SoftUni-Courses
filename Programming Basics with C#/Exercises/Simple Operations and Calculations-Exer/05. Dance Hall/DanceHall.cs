using System;
namespace _05.Dance_Hall
{
    class DanceHall
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double square = double.Parse(Console.ReadLine());

            double roomSpace = (length * 100) * (width * 100);
            double squareSpace = (square * 100) * (square * 100);
            double bench = roomSpace / 10;
            double freeSpace = roomSpace - squareSpace - bench;
            double dancers = Math.Floor(freeSpace / (7000 + 40));

            Console.WriteLine(dancers);

        }
    }
}
