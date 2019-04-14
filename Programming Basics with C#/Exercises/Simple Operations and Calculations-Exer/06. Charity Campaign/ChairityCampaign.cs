using System;

namespace _06.Charity_Campaign
{
    class ChairityCampaign
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int chefsCount = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofret = int.Parse(Console.ReadLine());
            int penacle = int.Parse(Console.ReadLine());

            double cakePrice = 45;
            double gofretPrice = 5.8;
            double penaclePrice = 3.20;
            double totalCake = cakes * cakePrice;
            double totalGofret = gofret * gofretPrice;
            double totalPenackle = penacle * penaclePrice;
            double sumOneDay = chefsCount * (totalCake + totalGofret + totalPenackle);
            double totalSum = sumOneDay * days;
            double clearSum = totalSum - (totalSum * (1.00 / 8));

            Console.WriteLine("{0:0.00}", clearSum);
        }
    }
}
