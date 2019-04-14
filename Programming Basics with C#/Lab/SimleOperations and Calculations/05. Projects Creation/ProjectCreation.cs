using System;

namespace _05._Projects_Creation
{
    class ProjectCreation
    {
        static void Main()
        {
            string architect = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int timePerProject = 3;
            int totalTime = projectsCount * timePerProject;
            Console.WriteLine($"The architect {architect} will need {totalTime} hours to complete {projectsCount} project/s.");
        }
    }
}
