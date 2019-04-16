using System;

namespace _05._Computer_Firm
{
    class ComputerFirm
    {
        static void Main()
        {
            int computersCount = int.Parse(Console.ReadLine());

            double rating = 0;
            double sales = 0;
            double computerSales = 0;
            double rate = 0;

            for (int i = 0; i < computersCount; i++)
            {
                int computerSaleRate = int.Parse(Console.ReadLine());

                rating = computerSaleRate % 10;
                sales = computerSaleRate / 10;
                rate = rating + rate;
                for (int j = 0; j < computersCount; j++)
                {
                    if (rating == 2)
                    {
                        computerSales += sales * 0;
                    }
                    else if (rating == 3)
                    {
                        computerSales += sales * 0.5;
                    }
                    else if (rating == 4)
                    {
                        computerSales += sales * 0.7;
                    }
                    else if (rating == 5)
                    {
                        computerSales += sales * 0.85;
                    }
                    else if (rating == 6)
                    {
                        computerSales += sales * 1;
                    }
                }
            }
            double salecomps = computerSales / computersCount;
            double eachrate = rate / computersCount;

            Console.WriteLine("{0:0.00}", salecomps);
            Console.WriteLine("{0:0.00}", eachrate);
        }
    }
}
