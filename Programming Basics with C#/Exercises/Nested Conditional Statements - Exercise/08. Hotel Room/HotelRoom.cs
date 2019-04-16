using System;

namespace _08._Hotel_Room
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int sleeps = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartPrice = 0;
            double totalPriceStudio = 0;
            double totalPriceApart = 0;

            if (month == "May" || month == "October")
            {
                studioPrice += 50;
                apartPrice += 65;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice += 75.2;
                apartPrice += 68.7;
            }
            else if (month == "July" || month == "August")
            {
                studioPrice += 76;
                apartPrice += 77;
            }

            totalPriceApart = apartPrice * sleeps;
            totalPriceStudio = studioPrice * sleeps;
           
            if (sleeps > 14 && (month == "May" || month == "October"))
            {
                totalPriceStudio *= 0.7;
            }
            else if (sleeps > 7 && (month == "May" || month == "October"))
            {
                totalPriceStudio *= 0.95;
            }
            else if  (sleeps >14 && (month == "June" || month == "September"))
            {
                totalPriceStudio *= 0.8;
            }

            if (sleeps > 14)
            {
                totalPriceApart *= 0.9;
            }

            Console.WriteLine($"Apartment: {totalPriceApart:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}
