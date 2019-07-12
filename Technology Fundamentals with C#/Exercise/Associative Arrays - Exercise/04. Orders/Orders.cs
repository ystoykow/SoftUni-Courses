namespace _04._Orders
{
    using System;
    using System.Collections.Generic;

    public class Orders
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split();
            var products = new Dictionary<string, double[]>();
            while (command[0] != "buy")
            {
                string productName = command[0];
                double productPrice = double.Parse(command[1]);
                int productQuantity = int.Parse(command[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                products[productName][0] = productPrice;
                products[productName][1] += productQuantity;

                command = Console.ReadLine().Split();
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:f2}");
            }
        }
    }
}