namespace _03._Easter_Shopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EasterShopping
    {
        public static void Main()
        {
            var shops = Console.ReadLine().Split().ToList();
            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "Include")
                {
                    shops.Add(input[1]);
                }
                else if (command == "Visit")
                {
                    int number = int.Parse(input[2]);

                    if (number <= shops.Count)
                    {
                        if (input[1] == "first")
                        {
                            shops.RemoveRange(0, number);
                        }
                        else
                        {
                            shops.Reverse();
                            shops.RemoveRange(0, number);
                            shops.Reverse();
                        }
                    }
                }
                else if (command == "Prefer")
                {
                    int indexOfFirst = int.Parse(input[1]);
                    int indexOfSecond = int.Parse(input[2]);

                    if (indexOfFirst >= 0
                        && indexOfSecond >= 0
                        && indexOfFirst < shops.Count
                        && indexOfSecond < shops.Count)
                    {
                        string firstShop = shops[indexOfFirst];
                        string secondShop = shops[indexOfSecond];

                        shops.Insert(indexOfFirst, secondShop);
                        shops.RemoveAt(indexOfFirst + 1);
                        shops.Insert(indexOfSecond, firstShop);
                        shops.RemoveAt(indexOfSecond + 1);
                    }

                }
                else if (command == "Place")
                {
                    int indexOfShop = int.Parse(input[2]) + 1;

                    if (indexOfShop >= 0 && indexOfShop < shops.Count)
                    {
                        shops.Insert(indexOfShop, input[1]);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
