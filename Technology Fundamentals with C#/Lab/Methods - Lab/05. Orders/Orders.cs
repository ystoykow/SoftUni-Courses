namespace _05._Orders
{
    using System;

    public class Orders
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            int countOfProduct = int.Parse(Console.ReadLine());

            double result = CalcSumOfProduct(product, countOfProduct);
            Console.WriteLine($"{result:f2}");
            
        }
        public static double CalcSumOfProduct(string product, int count)
        {
            double price = 0;
            switch (product)
            {
                case "water":
                    price += 1.00;
                    break;
                case "coffee":
                    price += 1.5;
                    break;
                case "coke":
                    price += 1.4;
                    break;
                case "snacks":
                    price += 2;
                    break;
                default:
                    break;
            }
            return price * count;
        }
    }
}
