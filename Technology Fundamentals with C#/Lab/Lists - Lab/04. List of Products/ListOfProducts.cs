namespace _04._List_of_Products
{
    using System;
    using System.Collections.Generic;

    public class ListOfProducts
    {
        public static void Main()
        {
            int productCount = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < productCount; i++)
            {
                products.Add(Console.ReadLine());
            }
            
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
