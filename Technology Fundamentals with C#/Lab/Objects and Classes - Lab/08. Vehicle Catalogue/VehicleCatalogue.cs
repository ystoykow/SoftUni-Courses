namespace _08._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VehicleCatalogue
    {
        public class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public string HorsePower { get; set; }
        }

        public class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public string Weight { get; set; }
        }

        public class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }

        public static void Main()
        {
            Catalog vehicles = new Catalog();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split('/');
                if (tokens[0] == "Car")
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    string horsePower = tokens[3];
                    Car currentCar = new Car
                    {
                        Brand = brand,
                        HorsePower = horsePower,
                        Model = model
                    };

                    vehicles.Cars.Add(currentCar);
                }
                else
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    string weight = tokens[3];

                    Truck currentTruck = new Truck
                    {
                        Model = model,
                        Brand = brand,
                        Weight = weight
                    };

                    vehicles.Trucks.Add(currentTruck);
                }

                input = Console.ReadLine();
            }

            if (vehicles.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (var item in vehicles.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }

            if (vehicles.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (var item in vehicles.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }
}

