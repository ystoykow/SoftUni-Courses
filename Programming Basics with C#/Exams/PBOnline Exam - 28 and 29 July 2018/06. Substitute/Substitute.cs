using System;

namespace _06._Substitute
{
    class Substitute
    {
        static void Main()
        {
            int firstFirstNumber = int.Parse(Console.ReadLine());
            int firstSecondNumber = int.Parse(Console.ReadLine());
            int secondFirstNumber = int.Parse(Console.ReadLine());
            int secondSecondNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int firstnumber = firstFirstNumber; firstnumber <= 8; firstnumber++)
            {

                for (int secondnumber = 9; secondnumber >= firstSecondNumber; secondnumber--)
                {

                    for (int thirdnumber = secondFirstNumber; thirdnumber <= 8; thirdnumber++)
                    {

                        for (int forthnumber = 9; forthnumber >= secondSecondNumber; forthnumber--)
                        {

                            if (firstnumber % 2 == 0 && secondnumber % 2 == 1 && thirdnumber % 2 == 0 && forthnumber % 2 == 1)
                            {

                                if (firstnumber == thirdnumber && secondnumber == forthnumber)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine("{0}{1} - {2}{3}", firstnumber, secondnumber, thirdnumber, forthnumber);
                                    counter++;
                                }

                                if (counter == 6)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
