using System;

namespace _02._Mountain_Run
{
    class MountainRun
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double climb = meters * speed;
            double slowing = Math.Floor(meters / 50);
            double bonusTime = slowing * 30;
            double totalTime = bonusTime + climb;

            if (record <= totalTime)
            {
                Console.WriteLine("No! He was {0:0.00} seconds slower.", totalTime - record);
            }
            else
            {
                Console.WriteLine(" Yes! The new record is {0:0.00} seconds.", totalTime);
            }
        }
    }
}
