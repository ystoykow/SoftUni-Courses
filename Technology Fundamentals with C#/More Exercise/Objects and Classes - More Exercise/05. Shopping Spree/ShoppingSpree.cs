namespace _05._Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class ShoppingSpree
    {
        public class Person
        {
            public Person()
            {
                Bag = new List<string>();
            }

            public string Name { get; set; }

            public int Money { get; set; }

            public List<string> Bag { get; set; }
        }

        public class Product
        {
            public string Name { get; set; }

            public int Cost { get; set; }
        }

        public static void Main()
        {
            List<Person> listPersons = new List<Person>();
            List<Product> listProducts = new List<Product>();
            string[] nameAndMoney = Console.ReadLine().Split(new char[] { ';', '=' });
            string[] products = Console.ReadLine().Split(new char[] { ';', '=' });
            for (int i = 0; i < nameAndMoney.Length - 1; i++)
            {
                string name = nameAndMoney[i];
                int money = int.Parse(nameAndMoney[i + 1]);
                Person person = new Person
                {
                    Name = name,
                    Money = money
                };

                listPersons.Add(person);
                i++;
            }
            for (int i = 0; i < products.Length - 1; i++)
            {
                string name = products[i];
                int cost = int.Parse(products[i + 1]);
                var product = new Product
                {
                    Name = name,
                    Cost = cost
                };

                listProducts.Add(product);
                i++;
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split();
                string buyer = tokens[0];
                string product = tokens[1];
                int indexOfBuyer = listPersons.FindIndex(x => x.Name == buyer);
                int indexOfProduct = listProducts.FindIndex(x => x.Name == product);
                if (listPersons[indexOfBuyer].Money >= listProducts[indexOfProduct].Cost)
                {
                    listPersons[indexOfBuyer].Money -= listProducts[indexOfProduct].Cost;
                    listPersons[indexOfBuyer].Bag.Add(listProducts[indexOfProduct].Name);
                    Console.WriteLine($"{buyer} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{buyer} can't afford {product}");
                }

                input = Console.ReadLine();
            }

            foreach (var item in listPersons)
            {
                if (item.Bag.Count > 0)
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
            }
        }
    }
}
