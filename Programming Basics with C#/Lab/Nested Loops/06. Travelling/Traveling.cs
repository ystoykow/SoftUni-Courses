using System;

namespace _06._Travelling
{
    class Traveling
    {
        static void Main()
        {
            string place = Console.ReadLine();

            while (place != "End")
            {

                double budgetForPlace = double.Parse(Console.ReadLine());

                double sum = 0;

                while(budgetForPlace>sum)
                {
                    sum += double.Parse(Console.ReadLine());

                    if (sum>=budgetForPlace)
                    {
                        Console.WriteLine($"Going to {place}!");
                    }
                    
                }

                place = Console.ReadLine();
            }
        }
    }
}
