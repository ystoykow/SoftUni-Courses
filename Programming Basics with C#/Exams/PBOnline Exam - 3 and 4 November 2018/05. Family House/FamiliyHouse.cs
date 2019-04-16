using System;

namespace _05._Family_House
{
    class FamiliyHouse
    {
        static void Main()
        {
            int months = int.Parse(Console.ReadLine());

            double waterPrice = 20;
            double internet = 15;
            double others = 0;
            double electricity = 0;

            for (int i = 0; i < months; i++)
            {
                double currentElectricity = double.Parse(Console.ReadLine());

                electricity += currentElectricity;
                others += (currentElectricity + waterPrice + internet) * 1.20;
            }

            Console.WriteLine("Electricity: {0:0.00} lv", electricity);
            Console.WriteLine("Water: {0:0.00} lv", waterPrice * months);
            Console.WriteLine("Internet: {0:0.00} lv", internet * months);
            Console.WriteLine("Other: {0:0.00} lv", others);
            Console.WriteLine("Average: {0:0.00} lv", (electricity + (waterPrice * months) + (internet * months) + others) / months);
        }
    }
}
