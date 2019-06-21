namespace _07._Order_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class People
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }

    public class OrderByAge
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<People> listedPeoples = new List<People>();
            while (input != "End")
            {
                
                string[] tokens = input.Split();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                People people = new People
                {
                    Age = age,
                    ID = id,
                    Name = name
                };

                listedPeoples.Add(people);
                input = Console.ReadLine();
            }

            foreach (var item in listedPeoples.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}