namespace _11._Snowballs
{
    using System;
    using System.Numerics;

    class Snowballs
    {
        static void Main()
        {
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            BigInteger bestSnowballValue = 0;
            int bestSnowballQuality = 0;

            int snowballsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < snowballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballValue = snowballValue;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
