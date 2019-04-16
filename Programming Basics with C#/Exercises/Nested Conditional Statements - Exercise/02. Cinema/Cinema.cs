using System;

namespace _02._Cinema
{
    class Cinema
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double price = 0;

            if (type == "Premiere")
            {
                price += row * col * 12;
            }
            else if (type =="Normal")
            {
                price += row * col * 7.5;
            }
            else if (type =="Discount")
            {
                price += row * col * 5;
            }

            Console.WriteLine($"{price:f2} leva");
        }
    }
}
