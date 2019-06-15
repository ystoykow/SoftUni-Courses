namespace _02._Car_Race
{
    using System;
    using System.Linq;

    public class CarRace
    {
        public static void Main()
        {
            int[] bothRacersTimes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            double firstRacerTime = 0;
            double secondRacerTime = 0;

            for (int i = 0; i < bothRacersTimes.Length / 2; i++)
            {
                if (bothRacersTimes[i] != 0)
                {
                    firstRacerTime += bothRacersTimes[i];
                }
                else
                {
                    firstRacerTime *= 0.8;
                }
            }

            for (int i = bothRacersTimes.Length-1; i > bothRacersTimes.Length / 2; i--)
            {
                if (bothRacersTimes[i] != 0)
                {
                    secondRacerTime += bothRacersTimes[i];
                }
                else
                {
                    secondRacerTime *= 0.8;
                }
            }

            if (firstRacerTime < secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerTime}");
            }
        }
    }
}
