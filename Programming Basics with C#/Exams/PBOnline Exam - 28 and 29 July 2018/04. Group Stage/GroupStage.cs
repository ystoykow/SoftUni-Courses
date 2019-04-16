using System;

namespace _04._Group_Stage
{
    class GroupStage
    {
        static void Main()
        {
            string teamName = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());

            int result = 0;
            int points = 0;
            int goalDif = 0;

            for (int i = 0; i < playedGames; i++)
            {
                int goals = int.Parse(Console.ReadLine());
                int recievegoals = int.Parse(Console.ReadLine());

                result = goals - recievegoals;
                goalDif = goalDif + goals - recievegoals;

                if (result > 0)
                {
                    points = points + 3;
                }

                if (result == 0)
                {
                    points = points + 1;
                }

                if (result < 0)
                {
                    points = points + 0;
                }
            }

            if (goalDif >= 0)
            {
                Console.WriteLine("{0} has finished the group phase with {1} points.", teamName, points);
                Console.WriteLine("Goal difference: {0}.", goalDif);
            }
            else
            {
                Console.WriteLine("{0} has been eliminated from the group phase.", teamName);
                Console.WriteLine("Goal difference: {0}.", goalDif);
            }
        }
    }
}
