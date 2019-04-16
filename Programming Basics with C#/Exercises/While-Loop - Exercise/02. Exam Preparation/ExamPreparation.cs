using System;

namespace _02._Exam_Preparation
{
    class ExamPreparation
    {
        static void Main()
        {
            int countBadGrade = int.Parse(Console.ReadLine());

            int count = 0;
            double gradeSum = 0;
            int tasksCount = 0;
            string lastTask = string.Empty;
            string command = string.Empty;
            int grade = 0;

            while (countBadGrade>count)
            {
                command = Console.ReadLine();

                if (command == "Enough")
                {
                    break;
                }

                grade = int.Parse(Console.ReadLine());
                lastTask = command;

                if (grade <= 4)
                {
                    count++;
                }

                gradeSum += grade;
                tasksCount++;
            }

            if (command == "Enough")
            {
                Console.WriteLine($"Average score: {gradeSum/tasksCount:f2}");
                Console.WriteLine($"Number of problems: {tasksCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            else
            {
                Console.WriteLine($"You need a break, {count} poor grades.");
            }
        }
    }
}
