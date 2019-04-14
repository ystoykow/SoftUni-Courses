using System;
namespace _07.Alcohol_Market
{
    class Program
    {
        static void Main()
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double countBeer = double.Parse(Console.ReadLine());
            double countWine = double.Parse(Console.ReadLine());
            double countRakia = double.Parse(Console.ReadLine());
            double countWhiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWhiskey / 2;
            double priceWine = priceRakia - (0.4 * priceRakia);
            double priceBeer = priceRakia - (0.8 * priceRakia);
            double totalRakia = priceRakia * countRakia;
            double totalWine = countWine * priceWine;
            double totalBeer = countBeer * priceBeer;
            double totalWhiskey = countWhiskey * priceWhiskey;
            double totalSum = totalBeer + totalRakia + totalWhiskey + totalWine;

            Console.WriteLine("{0:0.00}", totalSum);
        }
    }
}
