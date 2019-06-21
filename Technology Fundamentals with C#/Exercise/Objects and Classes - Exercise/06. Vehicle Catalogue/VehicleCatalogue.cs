namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VehicleCatalogue
    {
        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsepower;
            }

            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int HorsePower { get; set; }

            public override string ToString()
            {
                string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                    $"Model: {this.Model}{Environment.NewLine}" +
                                    $"Color: {this.Color}{Environment.NewLine}" +
                                    $"Horsepower: {this.HorsePower}";

                return vehicleStr;
            }
        }

        public static void Main()
        {
            List<Vehicle> listVehicles = new List<Vehicle>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split();
                string type = tokens[0].ToLower();
                string model = tokens[1];
                string color = tokens[2];
                int hp = int.Parse(tokens[3]);
                Vehicle vehicle = new Vehicle(type, model, color, hp);
                listVehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                Console.WriteLine(listVehicles.Find(v => v.Model == input));
                input = Console.ReadLine();
            }

            double avgCarHP = listVehicles.Where(x=>x.Type=="car").Select(x => x.HorsePower).DefaultIfEmpty(0).Average();
            double avgTruckHP = listVehicles.Where(x => x.Type == "truck").Select(x => x.HorsePower).DefaultIfEmpty(0).Average();

            Console.WriteLine($"Cars have average horsepower of: {avgCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHP:f2}.");
        }
    }
}
