using System;

namespace _05._Time___15_Minutes
{
    class TimePlus15Min
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >=60)
            {
                hours++;
                minutes %= 60;
            }
            if (hours>23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes.ToString("00")}");
        }
    }
}
