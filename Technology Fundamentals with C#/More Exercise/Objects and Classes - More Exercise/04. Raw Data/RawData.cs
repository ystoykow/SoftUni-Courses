namespace _04._Raw_Data
{
    using System;
    using System.Collections.Generic;

    public class RawData
    {
        public class Car
        {
            public Car()
            {
                Cargo = new Cargo();
                Engine = new Engine();
            }

            public string Model { get; set; }

            public Cargo Cargo { get; set; }

            public Engine Engine { get; set; }
        }

        public class Cargo
        {
            public int Weight { get; set; }

            public string Type { get; set; }
        }

        public class Engine
        {
            public int MaxSpeed { get; set; }

            public int HorsePower { get; set; }
        }

       public static void Main()
        {
            List<Car> carList = new List<Car>();
            int countCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCars; i++)
            {
                string[] info = Console.ReadLine().Split();
                string model = info[0];
                int speed = int.Parse(info[1]);
                int power = int.Parse(info[2]);
                int weight = int.Parse(info[3]);
                string type = info[4];
                Car car = new Car
                {
                    Model = model,
                    Cargo = new Cargo
                    {
                        Type = type,
                        Weight = weight
                    },
                    Engine = new Engine
                    {
                        HorsePower = power,
                        MaxSpeed = speed
                    }
                };

                carList.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var item in carList)
                {
                    if (item.Cargo.Type == "fragile" && item.Cargo.Weight < 1000)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            }
            else
            {
                foreach (var item in carList)
                {
                    if (item.Cargo.Type == "flamable" && item.Engine.HorsePower > 250)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            }
        }
    }
}
