using System;

namespace _08._Moving
{
    class Cake
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int cakeArea = width * length;

            while (command != "STOP")
            {
                int cake = int.Parse(command);

                cakeArea -= cake;

                if (cakeArea < 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "STOP")
            {
                Console.WriteLine($"{cakeArea} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need { Math.Abs(cakeArea)} pieces more.");
            }
        }
    }
}
