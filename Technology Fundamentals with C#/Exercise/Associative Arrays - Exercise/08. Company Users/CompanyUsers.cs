namespace _08._Company_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CompanyUsers
    {
        public static void Main()
        {
            Dictionary<string, List<string>> companyEmploy = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split(" -> ");
            while (command[0] != "End")
            {
                string companyName = command[0];
                string employeeId = command[1];
                if (!companyEmploy.ContainsKey(companyName))
                {
                    companyEmploy.Add(companyName, new List<string>()); ;
                }

                if (!companyEmploy[companyName].Contains(employeeId))
                {
                    companyEmploy[companyName].Add(employeeId);
                }

                command = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companyEmploy.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");
                Console.WriteLine("-- " + string.Join(Environment.NewLine + "-- ", company.Value));
            }
        }
    }
}