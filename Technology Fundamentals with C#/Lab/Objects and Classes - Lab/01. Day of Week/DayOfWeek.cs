namespace _01._Day_of_Week
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
