namespace _03._House_Party
{
    using System;
    using System.Collections.Generic;

    public class HouseParty
    {
        public static void Main()
        {
            int countCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < countCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[2] == "going!")
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
                else
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,guests));
        }
    }
}
