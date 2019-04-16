using System;

namespace _06._Ticket_Combination
{
    class TicketCombination
    {
        static void Main()
        {
            int combinationNumber = int.Parse(Console.ReadLine());

            int count = 0;

            for (char stadionName = 'B'; stadionName <= 'L'; stadionName++)
            {

                for (char sector = 'f'; sector >= 'a'; sector--)
                {

                    for (char enter = 'A'; enter <= 'C'; enter++)
                    {

                        for (int row = 1; row <= 10; row++)
                        {

                            for (int seat = 10; seat >= 1; seat--)
                            {

                                if (stadionName % 2 == 0)
                                {
                                    count++;

                                    if (count == combinationNumber)
                                    {
                                        int prize = stadionName + sector + enter + row + seat;
                                        Console.WriteLine("Ticket combination: {0}{1}{2}{3}{4}", stadionName, sector, enter, row, seat);
                                        Console.WriteLine("Prize: {0} lv.", prize);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
