namespace _03._Vacation
{
    using System;

    class Vacation
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerOne = 0;

            if (peopleType=="Students")
            {
                if (day=="Friday")
                {
                    pricePerOne += 8.45;
                }
                else if (day=="Saturday")
                {
                    pricePerOne += 9.8;
                }
                else if (day=="Sunday")
                {
                    pricePerOne += 10.46;
                }
            }
            else if (peopleType=="Business")
            {
                if (day == "Friday")
                {
                    pricePerOne += 10.9;
                }
                else if (day == "Saturday")
                {
                    pricePerOne += 15.6;
                }
                else if (day == "Sunday")
                {
                    pricePerOne += 16;
                }
            }
            else if(peopleType=="Regular")
            {
                if (day == "Friday")
                {
                    pricePerOne += 15;
                }
                else if (day == "Saturday")
                {
                    pricePerOne += 20;
                }
                else if (day == "Sunday")
                {
                    pricePerOne += 22.5;
                }
            }

            double priceForAll = pricePerOne * peopleCount;

            if(peopleType=="Students" && peopleCount>=30)
            {
                priceForAll *= 0.85;
            }
            else if(peopleType=="Business" && peopleCount>=100)
            {
                priceForAll -= pricePerOne * 10;
            }
            else if(peopleType=="Regular" && peopleCount>=10 && peopleCount<=20)
            {
                priceForAll *= 0.95;
            }
            Console.WriteLine($"Total price: {priceForAll:f2}");
        }
    }
}
