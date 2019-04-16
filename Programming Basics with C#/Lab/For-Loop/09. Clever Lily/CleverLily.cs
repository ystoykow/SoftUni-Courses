using System;

namespace _09._Clever_Lily
{
    class CleverLily
    {
        static void Main(string[] args)
        {
            int liliYears = int.Parse(Console.ReadLine());
            double washMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double sumMoney = 0;
            int toysCounter = 0;
            int counter = 0;

            for (int i = 1; i <= liliYears; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    sumMoney += 10 * counter ;
                }
                else
                {
                    toysCounter++;
                }
            }

            int toySum = toysCounter * toyPrice;
            double totalSum = (toySum + sumMoney) - counter;

            if (washMachine>totalSum)
            {
                Console.WriteLine($"No! {washMachine-totalSum:f2}");
            }
            else
            {
                Console.WriteLine($"Yes! {totalSum-washMachine:f2}");
            }
        }
    }
}
