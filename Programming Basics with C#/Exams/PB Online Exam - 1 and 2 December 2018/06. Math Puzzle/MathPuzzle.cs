using System;

namespace _06._Math_Puzzle
{
    class MathPuzzle
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());

            bool firstCase = false;
            bool secondCase = false;
            for (int a = 1; a <= 30; a++)
            {

                for (int b = 1; b <= 30; b++)
                {

                    for (int c = 1; c <= 30; c++)
                    {

                        if ((a + b + c == key) && a < b && b < c)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, key);

                            firstCase = true;
                        }
                        if ((a * b * c == key) && a > b && b > c)
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, key);

                            secondCase = true;
                        }
                    }
                }
            }

            if (firstCase == false && secondCase == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
