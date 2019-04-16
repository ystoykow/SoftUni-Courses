using System;

namespace _06._Unique_PIN_Codes
{
    class UniquePINcodes
    {
        static void Main()
        {
            int P = int.Parse(Console.ReadLine());
            int I = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            for (int p = 1; p <= P; p++)
            {

                for (int i = 1; i <= I; i++)
                {

                    for (int n = 1; n <= N; n++)
                    {

                        if (p % 2 == 0 && n % 2 == 0)
                        {

                            if (i == 2 || i == 3 || i == 5 || i == 7)
                            {
                                Console.WriteLine("{0} {1} {2}", p, i, n);
                            }
                        }
                    }
                }
            }
        }
    }
}
