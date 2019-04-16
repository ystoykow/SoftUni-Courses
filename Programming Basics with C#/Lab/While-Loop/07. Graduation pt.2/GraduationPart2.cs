using System;

namespace _06._Graduation
{
    class GraduationPart2
    {
        static void Main()
        {
            string name = Console.ReadLine();

            double grade = 0;
            double gradeSum = 0;
            int count = 1;
            int gradeCount = 0;
            int fail = 0;

            while (count <= 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    gradeSum += grade;
                    count++;
                }
                else
                {
                    gradeSum += grade;
                    fail++;
                }

                gradeCount++;

                if (fail == 2)
                {
                    break;
                }
            }

            if (fail!=2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeSum /gradeCount:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at { count} grade");
            }
        }
    }
}

