namespace _03._SoftUni_Bar_Income
{
    using System;
    using System.Text.RegularExpressions;

    public class SoftUniBarIncome
    {
        public static void Main()
        {
            string pattern =
                @"\%(?<customer>[A-Z][a-z]+)\%[^\%|.$]*<(?<product>\w+)>[^\%|.$]*\|(?<count>\d+)\|[^\%|.$]*?(?<price>(\d+|\d+\.\d+))\$";
            string input = Console.ReadLine();
            double totalIncome = 0;
            while (input != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    string customer = Regex.Match(input, pattern).Groups["customer"].Value;
                    string product = Regex.Match(input, pattern).Groups["product"].Value;
                    int count = int.Parse(Regex.Match(input, pattern).Groups["count"].Value);
                    double price = double.Parse(Regex.Match(input, pattern).Groups["price"].Value);
                    Console.WriteLine($"{customer}: {product} - {count * price:f2}");
                    totalIncome += count * price;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}


