namespace _01._Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Employee
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }
    }

    public class CompanyRoster
    {
        public static void Main()
        {
            int countEmployers = int.Parse(Console.ReadLine());
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < countEmployers; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string department = tokens[2];
                Employee employee = new Employee
                {
                    Department = department,
                    Name = name,
                    Salary = salary
                };

                listEmployee.Add(employee);
            }

            double avgSalary = 0;
            string highestDepartment = string.Empty;
            foreach (var department in listEmployee.Select(d => d.Department))
            {
                var currentAvgSalary = listEmployee.Where(d => d.Department == department).Select(s => s.Salary).Average();
                if (avgSalary < currentAvgSalary)
                {
                    avgSalary = currentAvgSalary;
                    highestDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestDepartment}");
            foreach (var employee in listEmployee.Where(e => e.Department == highestDepartment).OrderByDescending(s => s.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}