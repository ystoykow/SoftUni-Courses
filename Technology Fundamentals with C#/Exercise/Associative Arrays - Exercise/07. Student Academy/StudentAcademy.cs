namespace _07._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentAcademy
    {
        public static void Main()
        {
            Dictionary<string, List<double>> studentMarks = new Dictionary<string, List<double>>();
            int pairs = int.Parse(Console.ReadLine());
            for (int i = 0; i < pairs; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!studentMarks.ContainsKey(studentName))
                {
                    studentMarks.Add(studentName, new List<double>());
                }

                studentMarks[studentName].Add(studentGrade);
            }

            foreach (var kvp in studentMarks
                .Where(x=>x.Value.Average()>=4.50)
                .OrderByDescending(x=>x.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}