using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double pricePerKM = double.Parse(Console.ReadLine());
            double foodExpensesPerPerson = double.Parse(Console.ReadLine());
            double hotelPerPersonPerNight = double.Parse(Console.ReadLine());

            if (people > 10)
            {
                hotelPerPersonPerNight *= 0.75;
            }

            double currentExpenses = hotelPerPersonPerNight * people * days + foodExpensesPerPerson * people * days;
            for (int i = 1; i <= days; i++)
            {
                double distanceInKM = double.Parse(Console.ReadLine());

                currentExpenses += distanceInKM * pricePerKM;

                if (currentExpenses>budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses-budget:f2}$ more.");
                    break;
                }
                
                if (i % 3 == 0 || i%5==0)
                {
                    currentExpenses += currentExpenses * 0.4;
                    if (currentExpenses > budget)
                    {
                        Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses - budget:f2}$ more.");
                        break;
                    }
                }
                if (i % 7 == 0)
                {
                    currentExpenses -= currentExpenses / people;
                }

            }
            if (budget>=currentExpenses)
            {
                Console.WriteLine($"You have reached the destination. You have {budget-currentExpenses:f2}$ budget left.");

            }
        }
    }
}
