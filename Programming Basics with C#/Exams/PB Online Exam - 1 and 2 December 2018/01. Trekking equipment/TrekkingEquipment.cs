using System;

namespace _01._Trekking_equipment
{
    class TrekkingEquipment
    {
        static void Main()
        {
            double carabinerPrice = 36;
            double ropePrice = 3.60;
            double picellePrice = 19.80;

            double mountaineerCount = double.Parse(Console.ReadLine());
            double carabinerCount = double.Parse(Console.ReadLine());
            double ropeCount = double.Parse(Console.ReadLine());
            double picelleCount = double.Parse(Console.ReadLine());

            double mountaineerTotal = (carabinerPrice * carabinerCount) + (picelleCount * picellePrice) + (ropeCount * ropePrice);
            double allMountaineers = mountaineerTotal * mountaineerCount;
            double total = allMountaineers * 1.20;

            Console.WriteLine("{0:0.00}", total);
        }
    }
}
