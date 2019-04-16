using System;

namespace _04._Best_Player
{
    class BestPlayer
    {
        static void Main()
        {
            string player = Console.ReadLine();

            string bestplayer = string.Empty;
            int bestgoals = 0;
            bool hetrick = false;

            while (player != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > bestgoals)
                {
                    bestgoals = goals;
                    bestplayer = player;
                }

                if (bestgoals >= 3)
                {
                    hetrick = true;
                }

                if (bestgoals >= 10)
                {
                    break;
                }

                player = Console.ReadLine();
            }

            Console.WriteLine($"{bestplayer} is the best player!");

            if (hetrick == true)
            {
                Console.WriteLine($"He has scored {bestgoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestgoals} goals.");
            }
        }
    }
}
