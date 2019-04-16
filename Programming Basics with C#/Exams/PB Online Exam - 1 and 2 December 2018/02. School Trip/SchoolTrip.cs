using System;

namespace _02._School_Trip
{
    class SchoolTrip
    {
        static void Main()
        {
            double daysOff = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double firstDog = double.Parse(Console.ReadLine());
            double secondDog = double.Parse(Console.ReadLine());
            double thirdDog = double.Parse(Console.ReadLine());

            double needfood = (firstDog * daysOff) + (secondDog * daysOff) + (thirdDog * daysOff);

            if (needfood <= food)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - needfood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(needfood - food));
            }
        }
    }
}
