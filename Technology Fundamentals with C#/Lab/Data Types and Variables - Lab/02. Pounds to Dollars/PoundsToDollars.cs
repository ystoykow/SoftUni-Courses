﻿namespace _02._Pounds_to_Dollars
{
    using System;

    class PoundsToDollars
    {
        static void Main()
        {
            double pounds = double.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
