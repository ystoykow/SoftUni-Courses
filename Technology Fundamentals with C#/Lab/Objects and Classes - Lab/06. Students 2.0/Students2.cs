namespace _06._Students_2._0
{
    using System;
    using System.Collections.Generic;

    public class Students2
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Hometown { get; set; }
        }

        public static void Main()
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (input != "end")
            {
                string[] tokens = input.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string hometown = tokens[3];

                Student currentStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };

                Student student = students.Find((s => s.FirstName == firstName && s.LastName == lastName));
                if (student == null)
                {
                    students.Add(currentStudent);
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;
                }

                input = Console.ReadLine();
            }

            string home = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.Hometown == home)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
