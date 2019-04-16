using System;

namespace _08._Ski_Trip
{
    class SkiTrip
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;

            if (days-1 <10)
            {
                if (room == "room for one person")
                {
                    price += (days - 1) * 18;
                }
                else if (room == "apartment")
                {
                    price += ((days - 1) * 25) * 0.7;
                }
                else if (room == "president apartment")
                {
                    price += ((days - 1) * 35) * 0.9;
                }
            }
            else if ((days - 1) >= 10 && (days-1) <= 15)
            {
                if (room == "room for one person")
                {
                    price += (days - 1) * 18;
                }
                else if (room == "apartment")
                {
                    price += ((days - 1) * 25) * 0.65;
                }
                else if (room == "president apartment")
                {
                    price += ((days - 1) * 35) * 0.85;
                }
            }
            else if (days - 1 > 15)
            {
                if (room == "room for one person")
                {
                    price += (days - 1) * 18;
                }
                else if (room == "apartment")
                {
                    price += ((days - 1) * 25) * 0.5;
                }
                else if (room == "president apartment")
                {
                    price += ((days - 1) * 35) * 0.8;
                }
            }
            if (feedback == "positive")
            {
                price += price * 0.25;
            }
            else if (feedback == "negative")
            {
                price -= price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
