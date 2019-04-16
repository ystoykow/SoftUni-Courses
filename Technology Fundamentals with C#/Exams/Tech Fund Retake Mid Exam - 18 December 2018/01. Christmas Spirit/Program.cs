using System;

namespace _01._Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int ornament = 2;
            int treeSkirt = 5;
            int treeGarlands = 3;
            int treeLights = 15;
            int spirit = 0;
            int price = 0;
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            for (int i = 1; i <= days; i++)
            {
                bool isSkirtAndGarlands = false;
                
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 10 == 0)
                {
                    spirit -= 20;
                    price += treeSkirt;
                    price += treeGarlands;
                    price += treeLights;
                }
                if (i % 3 == 0)
                {
                    price += treeSkirt * quantity;
                    price += treeGarlands * quantity;
                    spirit += 13;
                    isSkirtAndGarlands = true;
                }
                if (i % 5 == 0)
                {
                    price += treeLights * quantity;
                    spirit += 17;
                    if (isSkirtAndGarlands)
                    {
                        spirit += 30;
                    }
                }
                if (i % 2 == 0)
                {
                    price += ornament * quantity;
                    spirit += 5;
                }
                if (i==days&& i % 10 == 0)
                {
                    spirit -= 30;
                }
            }
            

            Console.WriteLine($"Total cost: {price}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
