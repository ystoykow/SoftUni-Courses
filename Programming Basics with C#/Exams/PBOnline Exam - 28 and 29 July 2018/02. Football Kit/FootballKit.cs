using System;

namespace _02._Football_Kit
{
    class FootballKit
    {
        static void Main()
        {
            int tshirt = int.Parse(Console.ReadLine());
            double sumForBall = double.Parse(Console.ReadLine());

            double pants = tshirt * 0.75;
            double socks = pants * 0.2;
            double shoes = (tshirt + pants) * 2;
            double totalSum = tshirt + pants + shoes + socks;
            double discount = (totalSum * 15) / 100;
            double discountedSum = totalSum - discount;
            double neededSum = sumForBall - discountedSum;

            if (discountedSum <= sumForBall)
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine("He needs {0:0.00} lv. more.", neededSum);
            }
            else
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine("His sum is {0:0.00} lv.", discountedSum);
            }
        }
    }
}
