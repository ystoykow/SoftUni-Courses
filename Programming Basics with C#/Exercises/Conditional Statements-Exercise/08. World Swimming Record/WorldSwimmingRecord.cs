using System;

namespace _08._World_Swimming_Record
{
    class WorldSwimmingRecord
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double slower = Math.Floor(distanceMeters / 15) * 12.5;
            double totalTime = (distanceMeters * secondsPerMeter) + slower;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
            
        }
    }
}
