using System;

namespace _09._On_Time_for_the_Exam
{
    class OnTimeForExam
    {
        static void Main()
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examTotalMinutes = hourExam * 60 + minutesExam;
            int arriveTotalMinutes = arriveHour * 60 + arriveMinutes;

            if (arriveTotalMinutes >= examTotalMinutes - 30 && arriveTotalMinutes <= examTotalMinutes)
            {
                if (arriveTotalMinutes == examTotalMinutes)
                {
                    Console.WriteLine("On time");
                }
                else if (arriveTotalMinutes >= examTotalMinutes - 30 && arriveTotalMinutes <= examTotalMinutes)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{Math.Abs(arriveTotalMinutes-examTotalMinutes)%60} minutes before the start");
                }
            }
            else if (arriveTotalMinutes < examTotalMinutes - 30)
            {
                Console.WriteLine("Early");
                if (arriveTotalMinutes > examTotalMinutes - 60 && arriveTotalMinutes <= examTotalMinutes)
                {
                    Console.WriteLine($"{Math.Abs(arriveTotalMinutes - examTotalMinutes) % 60} minutes before the start");
                }
                else if (arriveTotalMinutes <= examTotalMinutes - 60)
                {
                    Console.WriteLine($"{Math.Abs(arriveTotalMinutes - examTotalMinutes) / 60}:{Math.Abs(arriveTotalMinutes - examTotalMinutes) % 60:d2} hours before the start");
                }
            }
            else if (arriveTotalMinutes > examTotalMinutes)
            {
                Console.WriteLine("Late");
                if (arriveTotalMinutes < examTotalMinutes + 60 && arriveTotalMinutes > examTotalMinutes)
                {
                    Console.WriteLine($"{Math.Abs(arriveTotalMinutes - examTotalMinutes) % 60} minutes after the start");
                }
                else if (arriveTotalMinutes >= examTotalMinutes + 60)
                {
                    Console.WriteLine($"{Math.Abs(arriveTotalMinutes - examTotalMinutes) / 60}:{Math.Abs(arriveTotalMinutes - examTotalMinutes) % 60:d2} hours after the start");
                }

            }
        }
    }
}
