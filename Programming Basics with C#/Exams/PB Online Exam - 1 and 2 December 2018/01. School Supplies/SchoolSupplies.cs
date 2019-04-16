using System;

namespace _01._School_Supplies
{
    class SchoolSupplies
    {
        static void Main()
        {
            double penPrice = 5.80;
            double markerPrice = 7.20;
            double cleaner = 1.20;

            double penPacks = double.Parse(Console.ReadLine());
            double markerPacks = double.Parse(Console.ReadLine());
            double cleanerLiters = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double totalPens = penPrice * penPacks;
            double totalMarkers = markerPrice * markerPacks;
            double totalCleaner = cleaner * cleanerLiters;
            double totalPrice = totalPens + totalMarkers + totalCleaner;
            double totalDiscount = totalPrice - ((totalPrice * discount) / 100);

            Console.WriteLine("{0:0.000}", totalDiscount);
        }
    }
}
