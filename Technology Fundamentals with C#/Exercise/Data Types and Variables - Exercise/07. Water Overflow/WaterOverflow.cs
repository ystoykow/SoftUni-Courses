namespace _07._Water_Overflow
{
    using System;

    class WaterOverflow
    {
        static void Main()
        {
            int waterTankCapacity = 255;
            int pourCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < pourCount; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                if(waterTankCapacity-sum<litersToPour)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    sum+= litersToPour;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
