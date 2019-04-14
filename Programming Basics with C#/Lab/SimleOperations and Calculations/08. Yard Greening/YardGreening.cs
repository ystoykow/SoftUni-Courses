using System;

namespace _08._Yard_Greening
{
    class YardGreening
    {
        static void Main()
        {
            double totalArea = double.Parse(Console.ReadLine());
            double pricePerOne = 7.61;
            double price = pricePerOne * totalArea;
            double discount = price * 0.18;
            double totalPrice = price - discount;
            Console.WriteLine($"The final price is: {totalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
