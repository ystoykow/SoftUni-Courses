namespace _08._Beer_Kegs
{
    using System;

    class BeerKegs
    {
        static void Main()
        {
            int beerKegsCount = int.Parse(Console.ReadLine());
            string bestModel = string.Empty;
            double bestVolume = 0;

            for (int i = 0; i < beerKegsCount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume>bestVolume)
                {
                    bestModel = model;
                    bestVolume = volume;
                }
            }

            Console.WriteLine(bestModel);
        }
    }
}
