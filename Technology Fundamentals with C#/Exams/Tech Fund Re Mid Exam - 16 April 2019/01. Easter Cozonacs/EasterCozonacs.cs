namespace _01._Easter_Cozonacs
{
    using System;

    public class EasterCozonacs
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double floorPrice = double.Parse(Console.ReadLine());
            double eggsPrice = floorPrice * 0.75;
            double milkPrice = floorPrice * 1.25;
            double pricePerCozunac = floorPrice + eggsPrice + (milkPrice / 4);
           
            int countCozonacs = 0;
            int coloredEggs = 0;
            while (budget>=pricePerCozunac)
            {
                budget -= pricePerCozunac;

                countCozonacs++;
                coloredEggs += 3;

                if (countCozonacs % 3 == 0)
                {
                    coloredEggs -= countCozonacs - 2;
                }
            }
            Console.WriteLine($"You made {countCozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
