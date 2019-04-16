using System;

namespace _04._Christmas_Gifts
{
    class ChristmasGifts
    {
        static void Main()
        {
            string command = Console.ReadLine();

            int countOld = 0;
            int countNew = 0;

            while (command != "Christmas")
            {
                int age = int.Parse(command);

                if (age > 16)
                {
                    countOld++;
                }
                else
                {
                    countNew++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Number of adults: {0}", countOld);
            Console.WriteLine("Number of kids: {0}", countNew);
            Console.WriteLine("Money for toys: {0}", countNew * 5);
            Console.WriteLine("Money for sweaters: {0}", countOld * 15);
        }
    }
}
