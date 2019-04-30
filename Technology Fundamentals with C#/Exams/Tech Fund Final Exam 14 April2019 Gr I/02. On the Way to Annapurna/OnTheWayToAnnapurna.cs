namespace _02._On_the_Way_to_Annapurna
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OnTheWayToAnnapurna
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();

            while(input!="END")
            {
                string[] tokens = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Add")
                {
                    string storeName = tokens[1];
                    string[] items = tokens[2].Split(',', StringSplitOptions.RemoveEmptyEntries);

                    if (!stores.ContainsKey(storeName))
                    {
                        stores.Add(storeName, new List<string>());
                    }

                    for (int i = 0; i < items.Length; i++)
                    {
                        stores[storeName].Add(items[i]);
                    }

                }
                else if (tokens[0] == "Remove")
                {
                    string storeName = tokens[1];

                    if (stores.ContainsKey(storeName))
                    {
                        stores.Remove(storeName);
                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Stores list:");
            foreach (var store in stores.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
