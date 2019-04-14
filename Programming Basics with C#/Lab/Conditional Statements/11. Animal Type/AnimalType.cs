using System;

namespace _11._Animal_Type
{
    class AnimalType
    {
        static void Main()
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    {
                        Console.WriteLine("mammal");
                        break;
                    }
                case "snake":
                case "crocodile":
                case "tortoise":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("unknown");
                        break;
                    }
            }
        }
    }
}
