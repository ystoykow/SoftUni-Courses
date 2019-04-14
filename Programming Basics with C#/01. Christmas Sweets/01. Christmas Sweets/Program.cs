using System;

namespace _01.Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklava = double.Parse(Console.ReadLine());
            double priceMuffins = double.Parse(Console.ReadLine());
            double kgStollen = double.Parse(Console.ReadLine());
            double kgCandy = double.Parse(Console.ReadLine());
            double kgBiscuits = double.Parse(Console.ReadLine());
            double priceBiscuits = 7.50;
            double priceCandy = priceMuffins * 1.8;
            double priecStollen = priceBaklava * 1.6;
            double totalPriceStollen = priecStollen * kgStollen;
            double totalPriceCandy = priceCandy * kgCandy;
            double totalPriceBiscuits = priceBiscuits * kgBiscuits;
            double total = totalPriceStollen + totalPriceCandy + totalPriceBiscuits;
            Console.WriteLine("{0:0.00}",total);

        }
    }
}
