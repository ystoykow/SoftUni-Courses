using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int totalTime = first + second + third;
            int minutes = 0;
            int seconds = 0;
            minutes = totalTime / 60;
            seconds = totalTime % 60;

            Console.WriteLine($"{minutes}:{seconds.ToString("00")}");
        }
    }
}
