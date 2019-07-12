namespace _06._Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Courses
    {
       public static void Main()
        {
            string[] command = Console.ReadLine().Split(" : ");
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (command[0] != "end")
            {
                string courseName = command[0];
                string student = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(student);
                command = Console.ReadLine().Split(" : ");
            }

            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                kvp.Value.Sort();
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                Console.WriteLine("-- " + string.Join(Environment.NewLine +"-- ", kvp.Value));
            }
        }
    }
}