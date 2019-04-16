using System;

namespace _08._Cookie_factory
{
    class CookieFactory
    {
        static void Main()
        {
            int batches = int.Parse(Console.ReadLine());

            bool first = false;
            bool second = false;
            bool third = false;
            int counter = 0;

            while(counter!= batches)
            {
                string products = Console.ReadLine();

                if (products == "flour")
                {
                    first = true;
                }
                else if (products =="eggs")
                {
                    second = true;
                }
                else if (products=="sugar")
                {
                    third = true;
                }

                if (products=="Bake!" && first && second && third)
                {
                    counter++;

                    Console.WriteLine($"Baking batch number {counter}...");

                    first = false;
                    second = false;
                    third = false;
                    
                }
                else if (products=="Bake!")
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
            }
        }
    }
}
