using System;

namespace _07._Train_The_Trainers
{
    class Program
    {
        static void Main()
        {
            int trainers = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double avgGrade = 0;
            double avgAll = 0;
            int counter = 0;

            while (command != "Finish")
            {

                string presentation = command;

                for (int i = 1; i <= trainers; i++)
                {
                    double grades = double.Parse(Console.ReadLine());

                    avgGrade += grades;
                }

                avgGrade /= trainers;

                Console.WriteLine($"{presentation} - {avgGrade:f2}.");

                avgAll += avgGrade;
                avgGrade = 0;
                counter++;
                
                command = Console.ReadLine();
            }

            avgAll /= counter;

            Console.WriteLine($"Student's final assessment is {avgAll:f2}.");
        }
    }
}
