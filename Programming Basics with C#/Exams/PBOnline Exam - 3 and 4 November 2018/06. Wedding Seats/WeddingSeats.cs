using System;

namespace _06._Wedding_Seats
{
    class WeddingSeats
    {
        static void Main()
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int total = 0;

            for (char firstsector = 'A'; firstsector <= lastSector; firstsector++)
            {

                for (int i = 1; i <= rows; i++)
                {

                    if (i % 2 != 0)
                    {

                        for (int k = 1; k <= seats; k++)
                        {
                            Console.WriteLine("{0}{1}{2}", firstsector, i, (char)(k + 96));

                            total++;
                        }
                    }
                    else if (i % 2 == 0)
                    {

                        for (int k = 1; k <= seats + 2; k++)
                        {
                            Console.WriteLine("{0}{1}{2}", firstsector, i, (char)(k + 96));

                            total++;
                        }
                    }
                }
                rows++;
            }
            Console.WriteLine(total);
        }
    }
}
