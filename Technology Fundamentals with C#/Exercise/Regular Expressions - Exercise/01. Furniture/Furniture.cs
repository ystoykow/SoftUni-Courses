namespace _01._Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Furniture
    {
        public static void Main()
        {
            string pattern = @">>(?<name>[A-Z]{1,}[a-z]{0,})<<(?<price>[0-9\.]+)!(?<quantity>[0-9]+)";
            string input = Console.ReadLine();
            double sum = 0;
            List<string> products = new List<string>();
            while (input != "Purchase")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match currentProduct = Regex.Match(input, pattern);
                    string name = currentProduct.Groups["name"].Value;
                    double price = double.Parse(currentProduct.Groups["price"].Value);
                    int quantity = int.Parse(currentProduct.Groups["quantity"].Value);
                    products.Add(name);
                    sum += price * quantity;
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"Bought furniture:");
            if (products.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, products));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
