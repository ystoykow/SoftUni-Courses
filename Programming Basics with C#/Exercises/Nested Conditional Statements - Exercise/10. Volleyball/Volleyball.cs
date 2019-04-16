using System;

namespace _10._Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsTravel = int.Parse(Console.ReadLine());

            int playInSofia = 48 - weekendsTravel;
            double totalGames = 0;
            double playedSofiaWeekends = (playInSofia * 1.00) * (3 / 4.0);
            double playedHolidays = (holidays * 1.00) * (2 / 3.0);

            if (yearType == "leap")
            {
                totalGames += (playedSofiaWeekends + playedHolidays + weekendsTravel) * 1.15;
                Console.WriteLine(Math.Floor(totalGames));
            }
            else
            {
                totalGames += playedSofiaWeekends + playedHolidays + weekendsTravel;
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}
