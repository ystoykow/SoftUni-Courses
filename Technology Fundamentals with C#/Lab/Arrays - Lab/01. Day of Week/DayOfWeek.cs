namespace _01._Day_of_Week
{
    using System;

    class DayOfWeek
    {
        public static void Main()
        {
            string[] weekdays = new string[7];

            weekdays[0] = "Monday";
            weekdays[1] = "Tuesday";
            weekdays[2] = "Wednesday";
            weekdays[3] = "Thursday";
            weekdays[4] = "Friday";
            weekdays[5] = "Saturday";
            weekdays[6] = "Sunday";

            int day = int.Parse(Console.ReadLine());

            if (day > 0 && day <= 7)
            {
                Console.WriteLine(weekdays[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
