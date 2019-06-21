namespace _05._Students
{
    using System;
    using System.Collections.Generic;

    public class Students
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
            while (input!="end")
            {
                string[] tokens = input.Split();
                Student currentStudent = new Student
                {
                    FirstName = tokens[0],
                    LastName = tokens[1],
                    Age = int.Parse(tokens[2]),
                    Hometown = tokens[3]
                };

                students.Add(currentStudent);
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
