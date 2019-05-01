namespace _02._Feed_the_Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FeedTheAnimals
    {
        public static void Main()
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            Dictionary<string, int> areas = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "Last Info")
            {
                var tokens = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string name = tokens[1];
                int food = int.Parse(tokens[2]);
                string area = tokens[3];
                if (command == "Add")
                {
                    if (!areas.ContainsKey(area))
                    {
                        areas.Add(area, 1);
                    }
                    else if (areas.ContainsKey(area) && !animals.ContainsKey(name))
                    {
                        areas[area]++;
                    }
                    if (!animals.ContainsKey(name))
                    {
                        animals.Add(name, food);
                    }
                    else if (animals.ContainsKey(name))
                    {
                        animals[name] += food;
                    }
                    
                }
                else
                {
                    if (animals.ContainsKey(name))
                    {
                        animals[name] -= food;
                        if (animals[name]<=0)
                        {
                            animals.Remove(name);

                            Console.WriteLine($"{name} was successfully fed");

                            areas[area]--;

                            if (areas[area]<=0)
                            {
                                areas.Remove(area);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Animals:");
            foreach (var item in animals.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}g");
            }
            Console.WriteLine("Areas with hungry animals:");
            foreach (var item in areas.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
