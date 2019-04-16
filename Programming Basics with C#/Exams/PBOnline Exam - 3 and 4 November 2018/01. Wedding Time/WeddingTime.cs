using System;

namespace _01._Wedding_Time
{
    class WeddingTime
    {
        static void Main()
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double waterLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double shampaneLiters = double.Parse(Console.ReadLine());
            double whiskyLiters = double.Parse(Console.ReadLine());

            double shampanePrice = whiskyPrice * 0.5;
            double winePrice = shampanePrice * 0.4;
            double waterPrice = shampanePrice * 0.1;
            double whisky = whiskyPrice * whiskyLiters;
            double water = waterPrice * waterLiters;
            double wine = wineLiters * winePrice;
            double shampane = shampaneLiters * shampanePrice;
            double totalSum = whisky + water + wine + shampane;

            Console.WriteLine("{0:0.00}", totalSum);
        }
    }
}
