using System;

namespace _04.Tailoring_Workshop
{
    class TailoringWorkshop
    {
        static void Main()
        {
            double rectangleTabbles = double.Parse(Console.ReadLine());
            double lenghtRectangleTabbles = double.Parse(Console.ReadLine());
            double widthRectangleTabbles = double.Parse(Console.ReadLine());

            double cover = rectangleTabbles * (lenghtRectangleTabbles + 2 * 0.30) * (widthRectangleTabbles + 2 * 0.30);
            double box = rectangleTabbles * (lenghtRectangleTabbles / 2) * (lenghtRectangleTabbles / 2);
            double priceUSD = cover * 7 + box * 9;
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine("{0:0.00} USD", priceUSD);
            Console.WriteLine("{0:0.00} BGN", priceBGN);
        }
    }
}
