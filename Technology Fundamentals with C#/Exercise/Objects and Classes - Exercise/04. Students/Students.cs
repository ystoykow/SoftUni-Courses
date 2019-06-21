namespace _04._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Students
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }

        public static void Main()
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countStudents; i++)
            {
                string[] input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                students.Add(student);
            }

            foreach (var student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }
}
