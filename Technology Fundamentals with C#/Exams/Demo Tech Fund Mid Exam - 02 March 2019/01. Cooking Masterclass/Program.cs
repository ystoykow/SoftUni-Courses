using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double apronTotalPrice = Math.Ceiling(students * 1.2)* apronPrice;
            double eggTotalPrice = eggPrice *10* students;
            double flourTotalPrice = flourPrice * (students - (students / 5));
            double totalSum = flourTotalPrice + eggTotalPrice + apronTotalPrice;
            if (budget >= totalSum)
            {
                Console.WriteLine($"Items purchased for {totalSum:f2}$.");
            }
            else
            {
                Console.WriteLine($"{Math.Round(totalSum - budget):f2}$ more needed.");
            }

        }
    }
}
