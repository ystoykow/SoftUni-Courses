using System;

namespace _07._Name_Wars
{
    class NameWars
    {
        static void Main()
        {
            string name = Console.ReadLine();

            string bestName = string.Empty;
            int bestNumber = 0;

            while (name != "STOP")
            {
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    sum +=name[i];
                }

                if (sum > bestNumber)
                {
                    bestNumber = sum;
                    bestName = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {bestName} - {bestNumber}!");
        }
    }
}
