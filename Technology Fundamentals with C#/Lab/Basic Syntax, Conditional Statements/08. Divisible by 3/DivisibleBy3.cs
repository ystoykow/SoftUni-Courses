﻿namespace _08._Divisible_by_3
{
    using System;

    class DivisibleBy3
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
