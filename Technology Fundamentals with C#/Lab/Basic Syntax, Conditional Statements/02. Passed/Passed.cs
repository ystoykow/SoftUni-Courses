﻿namespace _02._Passed
{
    using System;

    class Passed
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade>=3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
