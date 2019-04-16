using System;

namespace _06._Graduation
{
    class Graduation
    {
        static void Main()
        {
            string name = Console.ReadLine();

            double grade = 0;
            double gradeSum = 0;
            int count = 1;

            while (count <= 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    gradeSum += grade;
                    count++;
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {gradeSum / 12:f2}");
        }
    }
}

