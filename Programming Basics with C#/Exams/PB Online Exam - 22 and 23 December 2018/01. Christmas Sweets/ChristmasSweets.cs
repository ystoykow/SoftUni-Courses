using System;

namespace _01._Christmas_Sweets
{
    class ChristmasSweets
    {
        static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine());
            double muffinPrice = double.Parse(Console.ReadLine());
            double stollenKG = double.Parse(Console.ReadLine());
            double candyKG = double.Parse(Console.ReadLine());
            double biscuitsKG = double.Parse(Console.ReadLine());

            double biscuitsPrice = 7.50;
            double candyPrice = muffinPrice * 1.8;
            double stollenPrice = baklavaPrice * 1.6;
            double totalStollen = stollenPrice * stollenKG;
            double totalCandy = candyPrice * candyKG;
            double totalBiscuits = biscuitsPrice * biscuitsKG;
            double total = totalStollen + totalCandy + totalBiscuits;

            Console.WriteLine("{0:0.00}", total);
        }
    }
}
