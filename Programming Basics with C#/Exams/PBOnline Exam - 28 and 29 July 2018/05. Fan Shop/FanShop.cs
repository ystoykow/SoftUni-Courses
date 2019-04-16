using System;

namespace _05._Fan_Shop
{
    class FanShop
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            int price = 0;

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();

                switch (item)
                {
                    case "hoodie":
                        price += 30;
                        break;
                    case "keychain":
                        price += 4;
                        break;
                    case "T-shirt":
                        price += 20;
                        break;
                    case "flag":
                        price += 15;
                        break;
                    case "sticker":
                        price += 1;
                        break;
                    default:
                        break;
                }
            }

            double leftleva = budget - price;
            double needleva = price - budget;

            if (budget >= price)
            {
                Console.WriteLine("You bought {0} items and left with {1} lv.", count, leftleva);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0} more lv.", needleva);
            }
        }
    }
}
