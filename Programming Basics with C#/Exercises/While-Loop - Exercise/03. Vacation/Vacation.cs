using System;

namespace _03._Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double haveMoney = double.Parse(Console.ReadLine());

            int count = 0;
            int daysCount = 0;

            while (true)
            {
                string doing = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                daysCount++;

                if (doing == "spend")
                {
                    haveMoney -= money;

                    if (haveMoney<0)
                    {
                        haveMoney = 0;
                    }

                    count++;
                }
                else
                {
                    haveMoney += money;
                    count = 0;
                }

                if (needMoney<=haveMoney)
                {
                    Console.WriteLine($"You saved the money for { daysCount} days.") ;
                    break;
                }

                if (count ==5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCount}");
                    break;
                }

            }
        }
    }
}
