namespace _07._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StoreBoxes
    {
        public class Item
        {
            public string Name { get; set; }

            public double Price { get; set; }
        }

        public class Box
        {
            public string SerialNumber { get; set; }

            public Item Item { get; set; }

            public int ItemQuality { get; set; }

            public double Price { get; set; }
        }

        public static void Main()
        {
            string input = Console.ReadLine();
            var cart = new List<Box>();
            while (input != "end")
            {
                string[] tokens = input.Split();
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuality = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);

                var currentBox = new Box
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = itemName,
                        Price = itemPrice
                    },
                    ItemQuality = itemQuality,
                    Price = itemPrice*itemQuality
                };

                cart.Add(currentBox);
                input = Console.ReadLine();
            }

            foreach (var item in cart.OrderByDescending(x => x.Price))
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.ItemQuality}");
                Console.WriteLine($"-- ${item.Price:f2}");
            }
        }
    }
}
