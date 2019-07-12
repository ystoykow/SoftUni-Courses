namespace _05._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParking
    {
        public static void Main()
        {
            int countCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> dbUsers = new Dictionary<string, string>();
            for (int i = 0; i < countCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];

                if (command == "register")
                {

                    string plateNumber = input[2];

                    if (!dbUsers.ContainsKey(username))
                    {
                        dbUsers.Add(username, plateNumber);
                        Console.WriteLine($"{username} registered {dbUsers[username]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dbUsers[username]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!dbUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        dbUsers.Remove(username, out string s);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var users in dbUsers)
            {
                Console.WriteLine($"{users.Key} => {users.Value}");
            }
        }
    }
}