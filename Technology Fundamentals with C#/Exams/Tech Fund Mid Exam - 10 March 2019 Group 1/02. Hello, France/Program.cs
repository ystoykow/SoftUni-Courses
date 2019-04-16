using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            double earnedMoney = 0;
            string[] shopingCart = Console.ReadLine().Split('|');
            double budget = double.Parse(Console.ReadLine());
            List<double> newItemsPrice = new List<double>();
            for (int i = 0; i < shopingCart.Length; i++)
            {
                string[] currentItem = shopingCart[i].Split("->");
                string item = currentItem[0];
                double price = double.Parse(currentItem[1]);
                if (item == "Clothes")
                {
                    if (price<=50 && budget-price>=0)
                    {
                        budget -= price;
                        newItemsPrice.Add(price*1.4);
                        earnedMoney += (price * 1.4) - price;
                    }
                }
                else if (item == "Shoes")
                {
                    if (price <= 35 && budget - price >= 0)
                    {
                        budget -= price;
                        newItemsPrice.Add(price * 1.4);
                        earnedMoney += (price * 1.4) - price;
                    }
                }
                else if (item == "Accessories")
                {
                    if (price <= 20.5 && budget - price >= 0)
                    {
                        budget -= price;
                        newItemsPrice.Add(price * 1.4);
                        earnedMoney += (price * 1.4) - price;
                    }
                }
            }
            for (int i = 0; i < newItemsPrice.Count; i++)
            {
                double item = newItemsPrice[i];
                Console.Write($"{item:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {earnedMoney:f2}");
            if (budget+newItemsPrice.Sum()>= 150)
            {
                Console.WriteLine($"Hello, France!");
            }
            else
            {
                Console.WriteLine($"Time to go.");
            }
        }
    }
}
