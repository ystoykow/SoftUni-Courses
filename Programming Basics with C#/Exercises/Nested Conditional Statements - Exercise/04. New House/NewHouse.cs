using System;

namespace _04._New_House
{
    class NewHouse
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (type == "Roses")
            {
                price += count * 5;
                if (count > 80)
                {
                    price -= price * 0.1;
                }
            }
            else if (type == "Dahlias")
            {
                price += count * 3.8;
                if (count > 90)
                {
                    price -= price * 0.15;
                }
            }
            else if (type == "Tulips")
            {
                price += count * 2.8;
                if (count > 80)
                {
                    price -= price * 0.15;
                }
            }
            else if (type == "Narcissus")
            {
                price += count * 3;
                if (count < 120)
                {
                    price += price * 0.15;
                }
            }
            else if (type == "Gladiolus")
            {
                price += count * 2.5;
                if (count < 80)
                {
                    price += price * 0.2;
                }
            }
            if (budget>=price)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {budget-price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price-budget:f2} leva more.");
            }
        }
    }
}
