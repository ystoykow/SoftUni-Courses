using System;

namespace _05._Game_Info
{
    class GameInfo
    {
        static void Main()
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            double totalgametime = 0;
            double gameTime;
            double addTime = 0;
            double penalties = 0;

            for (int i = 0; i < games; i++)
            {
                gameTime = double.Parse(Console.ReadLine());

                totalgametime += gameTime;

                if (gameTime > 120)
                {
                    penalties++;
                }
                else if (gameTime > 90 && gameTime <= 120)
                {
                    addTime++;
                }
            }

            double avgtime = totalgametime / games;

            Console.WriteLine("{0} has played {1} minutes. Average minutes per game: {2:0.00}", team, totalgametime, avgtime);
            Console.WriteLine("Games with penalties: {0}", penalties);
            Console.WriteLine("Games with additional time: {0}", addTime);
        }
    }
}
