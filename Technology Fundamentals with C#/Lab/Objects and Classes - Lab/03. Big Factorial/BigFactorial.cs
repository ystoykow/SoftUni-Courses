﻿namespace _03._Big_Factorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}