namespace _03._Speed_Racing
{
    using System;
    using System.Collections.Generic;

    public class SpeedRacing
    {
        public class Car
        {
            public string Model { get; set; }

            public double FuelAmount { get; set; }

            public double FuelConsume { get; set; }

            public double TraveledKm { get; set; }

            public void Drive(Car car, double distance)
            {
                double neededFuel = distance * car.FuelConsume;
                if (neededFuel <= car.FuelAmount)
                {
                    car.FuelAmount -= neededFuel;
                    car.TraveledKm += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }

        public static void Main()
        {
            List<Car> carList = new List<Car>();
            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsume = double.Parse(carInfo[2]);

                Car car = new Car
                {
                    FuelAmount = fuelAmount,
                    FuelConsume = fuelConsume,
                    Model = model,
                    TraveledKm = 0
                };

                carList.Add(car);
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split();
                string model = tokens[1];
                double kmToDrive = double.Parse(tokens[2]);
                int indexOfCar = carList.FindIndex(x => x.Model == model);
                carList[indexOfCar].Drive(carList[indexOfCar], kmToDrive);
                input = Console.ReadLine();
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledKm}");
            }
        }
    }
}
