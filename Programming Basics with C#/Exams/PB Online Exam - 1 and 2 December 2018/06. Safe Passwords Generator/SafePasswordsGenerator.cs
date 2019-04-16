using System;

namespace _06._Safe_Passwords_Generator
{
    class SafePasswordsGenerator
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int symbolA = 35;
            int symbolB = 64;
            int count = 0;

            for (int i = 1; i <= a; i++)
            {

                for (int j = 1; j <= b; j++)
                {

                    if (symbolA > 55)
                    {
                        symbolA = 35;
                    }

                    if (symbolB > 96)
                    {
                        symbolB = 64;
                    }
                    Console.Write("{0}{1}{2}{3}{4}{5}|", (char)symbolA, (char)symbolB, i, j, (char)symbolB, (char)symbolA);

                    symbolA++;
                    symbolB++;
                    count++;

                    if (count == max)
                    {
                        return;
                    }
                }
            }
        }
    }
}
