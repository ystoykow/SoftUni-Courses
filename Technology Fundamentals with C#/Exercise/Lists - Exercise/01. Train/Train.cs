namespace _01._Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Train
    {
        public static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCap = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    wagons.Add(number);
                }
                else
                {
                    int number = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (maxCap >= number + wagons[i])
                        {
                            wagons[i] = wagons[i] + number;
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
