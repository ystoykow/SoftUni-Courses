using System;

namespace _02._Number_Pyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int newLine = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");

                counter++;

                if (counter== newLine)
                {
                    Console.WriteLine();

                    newLine++;
                    counter = 0;
                }
            }
        }
    }
}
