﻿using System;

namespace _02._Sequence_2k_1
{
    class Sequence2k
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int k = 1;

            while (k<=n)
            {
                Console.WriteLine(k);

                k = 2 * k + 1;
            }
        }
    }
}
