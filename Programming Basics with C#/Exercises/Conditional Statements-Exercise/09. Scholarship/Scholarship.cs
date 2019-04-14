using System;

namespace _09._Scholarship
{
    class Scholarship
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double excellentScholarship = Math.Floor(averageSuccess * 25);
            double socialScholarship = Math.Floor(minimalSalary * 0.35);

            if (averageSuccess >= 5.50)
            {
                if (excellentScholarship < socialScholarship && income<minimalSalary)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
                }
                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScholarship);
                }
            }
            else if (income < minimalSalary && averageSuccess >= 4.50)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
