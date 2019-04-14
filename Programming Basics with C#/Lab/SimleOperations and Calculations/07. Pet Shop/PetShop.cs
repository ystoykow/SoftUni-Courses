using System;

namespace _07._Pet_Shop
{
    class PetShop
    {
        static void Main()
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());
            double dogFoodPrice = 2.5;
            double otherAnimalsFoodPrice = 4;
            double totalSum = dogCount * dogFoodPrice + otherAnimals * otherAnimalsFoodPrice;
            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
