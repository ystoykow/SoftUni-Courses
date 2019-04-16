using System;

namespace _01._Trip_To_World_Cup
{
    class TripToWorldCup
    {
        static void Main()
        {
            double ticketGoing = double.Parse(Console.ReadLine());
            double ticketReturn = double.Parse(Console.ReadLine());
            double ticketPricePerMach = double.Parse(Console.ReadLine());
            int matchCount = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double ticketGoingAndReturning = 6 * (ticketGoing + ticketReturn);
            double discountTicketGoingAndReturning = (ticketGoingAndReturning) - ((ticketGoingAndReturning * discount) / 100);
            double allMachPrice = 6 * matchCount * ticketPricePerMach;
            double totalSum = discountTicketGoingAndReturning + allMachPrice;
            double eachFriendSum = totalSum / 6;

            Console.WriteLine("Total sum: {0:0.00} lv.", totalSum);
            Console.WriteLine("Each friend has to pay {0:0.00} lv.", eachFriendSum);
        }
    }
}
