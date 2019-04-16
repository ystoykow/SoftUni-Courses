using System;

namespace _03._Energy_Booster
{
    class EnergyBooster
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string pack = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            if (pack == "small")
            {

                switch (fruit)
                {
                    case "Watermelon":
                        price += 56 * 2;
                        break;
                    case "Mango":
                        price += 36.66 * 2;
                        break;
                    case "Pineapple":
                        price += 42.10 * 2;
                        break;
                    case "Raspberry":
                        price += 20 * 2;
                        break;
                    default:
                        break;
                }

                totalPrice = price * num;

                if (totalPrice >= 400 && totalPrice <= 1000)
                {
                    totalPrice = totalPrice * 0.85;

                    Console.WriteLine("{0:0.00} lv.", totalPrice);
                }
                else if (totalPrice > 1000)
                {
                    totalPrice = totalPrice * 0.5;

                    Console.WriteLine("{0:0.00} lv.", totalPrice);
                }
                else
                {
                    Console.WriteLine("{0:0.00} lv.", totalPrice);
                }
            }
            else if (pack == "big")
            {

                switch (fruit)
                {
                    case "Watermelon":
                        price += 28.70 * 5;
                        break;
                    case "Mango":
                        price += 19.60 * 5;
                        break;
                    case "Pineapple":
                        price += 24.80 * 5;
                        break;
                    case "Raspberry":
                        price += 15.20 * 5;
                        break;
                    default:
                        break;
                }

                totalPrice = price * num;

                if (totalPrice >= 400 && totalPrice <= 1000)
                {
                    totalPrice = totalPrice * 0.85;

                    Console.WriteLine("{0:0.00} lv.", totalPrice);
                }
                else if (totalPrice > 1000)
                {
                    totalPrice = totalPrice * 0.5;

                    Console.WriteLine("{0:0.00} lv.", totalPrice);
                }
                else
                {
                    Console.WriteLine("{0:0.00} lv.", totalPrice);
                }
            }
        }
    }
}
