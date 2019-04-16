using System;

namespace _06._Christmas_Decoration
{
    class ChristmasDecoration
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int count = 0;

            while (command != "Stop")
            {
                foreach (char c in command)
                {
                    count += c;
                }

                if (budget > count)
                {
                    budget = budget - count;

                    Console.WriteLine("Item successfully purchased!");

                    count = 0;
                }
                else if (budget < count)
                {
                    Console.WriteLine("Not enough money!");

                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "Stop")
            {
                Console.WriteLine("Money left: {0}", budget);
            }
        }
    }
}
