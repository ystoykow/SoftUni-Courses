using System;

namespace _06._Three_brothers
{
    class ThreeBrothers
    {
        static void Main()
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double fatherTime = double.Parse(Console.ReadLine());

            double brotherTime = (1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime)) * 1.15;

            if (brotherTime <= fatherTime)
            {
                Console.WriteLine($"Cleaning time: {brotherTime:f2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(fatherTime - brotherTime)} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {brotherTime:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(brotherTime - fatherTime)} hours.");
            }

        }
    }
}
