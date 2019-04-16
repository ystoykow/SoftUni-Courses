using System;

namespace _03._Ski_Trip
{
    class SkiTrip
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            days--;

            if (feedback == "positive")
            {

                if (room == "room for one person")
                {
                    price = 18;
                    totalPrice = (price * days) * 1.25;

                    Console.WriteLine("{0:0.00}", totalPrice);
                }
                else if (room == "apartment")
                {
                    price = 25;

                    if (days < 10)
                    {
                        totalPrice = ((price * days) * 0.70) * 1.25;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = ((price * days) * 0.65) * 1.25;
                    }
                    else if (days > 15)
                    {
                        totalPrice = ((price * days) * 0.50) * 1.25;
                    }

                    Console.WriteLine("{0:0.00}", totalPrice);
                }
                else if (room == "president apartment")
                {
                    price = 35;

                    if (days < 10)
                    {
                        totalPrice = ((price * days) * 0.90) * 1.25;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = ((price * days) * 0.85) * 1.25;
                    }
                    else if (days > 15)
                    {
                        totalPrice = ((price * days) * 0.80) * 1.25;
                    }

                    Console.WriteLine("{0:0.00}", totalPrice);
                }
            }
            else if (feedback == "negative")
            {
                if (room == "room for one person")
                {
                    price = 18;
                    totalPrice = (price * days) * 0.9;

                    Console.WriteLine("{0:0.00}", totalPrice);
                }
                else if (room == "apartment")
                {
                    price = 25;

                    if (days < 10)
                    {
                        totalPrice = ((price * days) * 0.70) * 0.9;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = ((price * days) * 0.65) * 0.9;
                    }
                    else if (days > 15)
                    {
                        totalPrice = ((price * days) * 0.50) * 0.9;
                    }

                    Console.WriteLine("{0:0.00}", totalPrice);
                }
                else if (room == "president apartment")
                {
                    price = 35;

                    if (days < 10)
                    {
                        totalPrice = ((price * days) * 0.90) * 0.9;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = ((price * days) * 0.85) * 0.9;
                    }
                    else if (days > 15)
                    {
                        totalPrice = ((price * days) * 0.80) * 0.9;
                    }

                    Console.WriteLine("{0:0.00}", totalPrice);
                }
            }
        }
    }
}
