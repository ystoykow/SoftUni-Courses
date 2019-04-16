using System;

namespace _03._Pastry_Shop
{
    class PastryShop
    {
        static void Main()
        {
            string type = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            if (day <= 15)
            {
                switch (type)
                {
                    case "Cake":
                        price += 24;
                        break;
                    case "Souffle":
                        price += 6.66;
                        break;
                    case "Baklava":
                        price += 12.60;
                        break;
                    default:
                        break;
                }
            }
            else if (day > 15)
            {
                switch (type)
                {
                    case "Cake":
                        price += 28.70;
                        break;
                    case "Souffle":
                        price += 9.80;
                        break;
                    case "Baklava":
                        price += 16.98;
                        break;
                    default:
                        break;
                }
            }

            if (day <= 22)
            {
                totalPrice = price * num;

                if (totalPrice >= 100 && totalPrice <= 200)
                {
                    totalPrice = totalPrice * 0.85;

                    if (day <= 15)
                    {
                        totalPrice = totalPrice * 0.9;
                    }
                }
                else if (totalPrice > 200)
                {
                    totalPrice = totalPrice * 0.75;

                    if (day <= 15)
                    {
                        totalPrice = totalPrice * 0.9;
                    }
                }
                else
                {
                    totalPrice = totalPrice * 0.9;
                }

                Console.WriteLine("{0:0.00}", totalPrice);
            }
            else
            {
                totalPrice = price * num;

                Console.WriteLine("{0:0.00}", totalPrice);
            }
        }
    }
}
