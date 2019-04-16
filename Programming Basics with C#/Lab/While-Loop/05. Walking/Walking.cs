using System;

namespace _05._Walking
{
    class Walking
    {
        static void Main()
        {
            int totalSteps = 10000;
            string command = string.Empty;

            while (totalSteps > 0)
            {
                command = Console.ReadLine();

                if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());

                    totalSteps -= stepsToHome;

                    break;
                }

                int steps = int.Parse(command);

                totalSteps -= steps;
            }

            if (totalSteps > 0)
            {
                Console.WriteLine($"{totalSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
