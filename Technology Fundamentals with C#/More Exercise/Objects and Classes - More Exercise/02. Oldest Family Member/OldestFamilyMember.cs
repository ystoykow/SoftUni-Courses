namespace _02._Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OldestFamilyMember
    {
        public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

        public class Family
        {
            public Family()
            {
                People = new List<Person>();
            }

            public List<Person> People { get; set; }

            public void AddMember(Person person)
            {
                People.Add(person);
            }

            public Person GetOldestMember()
            {
                return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
            }
        }

        public static void Main()
        {
            int countMember = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < countMember; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Person person = new Person
                {
                    Name = name,
                    Age = age
                };

                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}