using System;

namespace _01._Shopping_Time
{
    class ShoppingTime
    {
        static void Main()
        {
            int restTime = int.Parse(Console.ReadLine());
            double partPrice = double.Parse(Console.ReadLine());
            double programPrice = double.Parse(Console.ReadLine());
            double frapePrice = double.Parse(Console.ReadLine());

            int restForFrape = restTime - 5;
            int totalRest = restForFrape - ((3 * 2) + (2 * 2));
            double totalSum = frapePrice + (3 * partPrice) + (2 * programPrice);

            Console.WriteLine("{0:0.00}", totalSum);
            Console.WriteLine(totalRest);
        }
    }
}
