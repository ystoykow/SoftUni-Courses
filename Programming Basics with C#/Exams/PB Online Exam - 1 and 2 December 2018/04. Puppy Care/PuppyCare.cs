using System;

namespace _04._Puppy_Care
{
    class PuppyCare
    {
        static void Main()
        {
            int foodKG = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int foodGrams = foodKG * 1000;
            int food = 0;
            while (command != "Adopted")
            {
                int eaten = int.Parse(command);

                food += eaten;

                command = Console.ReadLine();

                if (command == "Adopted")
                {
                    break;
                }
            }
            if (foodGrams >= food)
            {
                Console.WriteLine("Food is enough! Leftovers: {0} grams.", foodGrams - food);
            }
            else
            {
                Console.WriteLine("Food is not enough. You need {0} grams more.", food - foodGrams);
            }
        }
    }
}
