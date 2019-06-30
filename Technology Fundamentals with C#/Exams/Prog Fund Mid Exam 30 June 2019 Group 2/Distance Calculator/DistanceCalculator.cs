namespace Distance_Calculator
{
    using System;

    public class DistanceCalculator
    {
        public static void Main()
        {
            int steps = int.Parse(Console.ReadLine());
            double stepLengthInCm = double.Parse(Console.ReadLine());
            int distanceToTravel = int.Parse(Console.ReadLine());
            double totalStepsLength = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    totalStepsLength += stepLengthInCm * 0.7;
                }
                else
                {
                    totalStepsLength += stepLengthInCm;
                }
            }

            double totalStepsInMeters = totalStepsLength / 100;
            double percent = (totalStepsInMeters / distanceToTravel) * 100;

            Console.WriteLine($"You travelled {percent:f2}% of the distance!");
        }
    }
}