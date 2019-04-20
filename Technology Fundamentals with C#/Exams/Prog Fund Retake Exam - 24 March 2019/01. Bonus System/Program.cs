namespace _01._Bonus_System
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            int[] students = new int[studentsCount];
            int maxLection = 0;
            int maxBonus = 0;
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = initialBonus;
            }

            for (int i = 0; i < students.Length; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                double totalAttendance = Math.Round((attendance / (lecturesCount * 1.0)) * (5 + initialBonus));
                students[i] = (int)totalAttendance;
                if (students[i] > maxBonus)
                {
                    maxBonus = students[i];
                    maxLection = attendance;
                }
            }

            Console.WriteLine($"The maximum bonus score for this course is {maxBonus}.The student has attended {maxLection} lectures.");
        }
    }
}
