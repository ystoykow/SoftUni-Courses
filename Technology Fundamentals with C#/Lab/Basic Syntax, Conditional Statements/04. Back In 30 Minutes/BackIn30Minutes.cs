namespace _04._Back_In_30_Minutes
{
    using System;

    class BackIn30Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes>=60)
            {
                hours++;
                minutes -= 60;
            }
            if (hours>=23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
