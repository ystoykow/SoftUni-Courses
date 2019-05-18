
namespace _07._Theatre_Promotion
{
    using System;

    class TheatrePromotion
    {
        static void Main()
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (dayType == "Weekday" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122)))
            {
                Console.WriteLine($"12$");
            }
            else if (dayType == "Weekday" && age > 18 && age <= 64)
            {
                Console.WriteLine($"18$");
            }
            else if (dayType == "Weekend" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122)))
            {
                Console.WriteLine($"15$");
            }
            else if (dayType == "Weekend" && age > 18 && age <= 64)
            {
                Console.WriteLine($"20$");
            }
            else if (dayType == "Holiday" && age >= 0 && age <= 18)
            {
                Console.WriteLine($"5$");
            }
            else if (dayType== "Holiday" && age >64 && age<=122)
            {
                Console.WriteLine("10$");
            }
            else if (dayType == "Holiday" && age >18 && age <=64)
            {
                Console.WriteLine("12$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
