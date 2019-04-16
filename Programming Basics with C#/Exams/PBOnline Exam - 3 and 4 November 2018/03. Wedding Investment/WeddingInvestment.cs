using System;

namespace _03._Wedding_Investment
{
    class WeddingInvestment
    {
        static void Main()
        {
            string contract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string dessert = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double contractTypePrice = 0;
            double dessertPrice = 0;
            double totalSum = 0;

            if (contract == "one")
            {
                switch (typeOfContract)
                {
                    case "Small":
                        contractTypePrice += 9.98;
                        break;
                    case "Middle":
                        contractTypePrice += 18.99;
                        break;
                    case "Large":
                        contractTypePrice += 25.98;
                        break;
                    case "ExtraLarge":
                        contractTypePrice += 35.99;
                        break;
                    default:
                        break;

                }

                if (dessert == "yes")
                {
                    if (contractTypePrice <= 10)
                    {
                        dessertPrice += 5.50;
                    }
                    else if (contractTypePrice <= 30)
                    {
                        dessertPrice += 4.35;
                    }
                    else if (contractTypePrice > 30)
                    {
                        dessertPrice += 3.85;
                    }
                }

                totalSum = months * (contractTypePrice + dessertPrice);

                Console.WriteLine("{0:0.00} lv.", totalSum);
            }
            else if (contract == "two")
            {
                switch (typeOfContract)
                {
                    case "Small":
                        contractTypePrice += 8.58;
                        break;
                    case "Middle":
                        contractTypePrice += 17.09;
                        break;
                    case "Large":
                        contractTypePrice += 23.59;
                        break;
                    case "ExtraLarge":
                        contractTypePrice += 31.79;
                        break;
                    default:
                        break;

                }

                if (dessert == "yes")
                {
                    if (contractTypePrice <= 10)
                    {
                        dessertPrice += 5.50;
                    }
                    else if (contractTypePrice <= 30)
                    {
                        dessertPrice += 4.35;
                    }
                    else if (contractTypePrice > 30)
                    {
                        dessertPrice += 3.85;
                    }
                }
                totalSum = (months * (contractTypePrice + dessertPrice)) * 0.9625;

                Console.WriteLine("{0:0.00} lv.", totalSum);
            }
        }
    }
}
