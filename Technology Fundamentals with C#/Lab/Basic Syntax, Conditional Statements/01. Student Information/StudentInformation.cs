﻿namespace _01._Student_Information
{
    using System;

    class StudentInformation
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
