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
            Dictionary<string, List<double>> salaries = new Dictionary<string, List<double>>();
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

                if (!salaries.ContainsKey(employee.Department))
                {
                    salaries.Add(employee.Department, new List<double>());
                }

                salaries[employee.Department].Add(employee.Salary);

            }

            double bestAvg = 0;
            string bestdep = string.Empty;
            foreach (var department in listEmployee.Select(d => d.Department))
            {
                var avg = listEmployee.Where(d => d.Department == department).Select(s => s.Salary).Average();
                if (bestAvg < avg)
                {
                    bestAvg = avg;
                    bestdep = department;
                }
            }

            string highestDepartment = string.Empty;
            double avgSalary = 0;
            foreach (var salary in salaries)
            {
                double current = salary.Value.Average();
                if (current > avgSalary)
                {
                    avgSalary = current;
                    highestDepartment = salary.Key;
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