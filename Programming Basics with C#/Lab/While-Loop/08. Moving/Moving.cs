using System;

namespace _08._Moving
{
    class Moving
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int freeSpace = width * length * hight;

            while (command != "Done" )
            {
                int boxes = int.Parse(command);

                freeSpace -= boxes;

                if (freeSpace<0)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command=="Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
        }
    }
}
