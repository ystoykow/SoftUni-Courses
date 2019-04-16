using System;

namespace _10._Special_Numbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {

                bool first = false;
                bool second = false;
                bool third = false;
                bool forth = false;
                int firstDigit = i % 10;
                int secondDigit = i / 10 % 10;
                int thirdDigit = i / 100 % 10;
                int forthDigit = i / 1000 % 10;

                if (firstDigit != 0 && number % firstDigit == 0)
                {

                    first = true;

                    if (secondDigit != 0 && number % secondDigit == 0)
                    {

                        second = true;

                        if (thirdDigit != 0 && number % thirdDigit == 0)
                        {

                            third = true;

                            if (forthDigit != 0 && number % forthDigit == 0)
                            {
                                forth = true;
                            }
                        }
                    }
                }

                if (first && second && third && forth)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
