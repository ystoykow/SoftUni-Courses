namespace Messages_Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MessagesManager
    {
        public static void Main()
        {
            Dictionary<string, int> usersSend = new Dictionary<string, int>();
            Dictionary<string, int> usersReceived = new Dictionary<string, int>();
            int capacity = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split("=", StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "Statistics")
            {
                if (commands[0] == "Add")
                {
                    string username = commands[1];
                    int sent = int.Parse(commands[2]);
                    int received = int.Parse(commands[3]);
                    if (!usersSend.ContainsKey(username) && !usersReceived.ContainsKey(username))
                    {
                        usersSend.Add(username, sent);
                        usersReceived.Add(username, received);
                    }
                }
                else if (commands[0] == "Message")
                {
                    string firstUser = commands[1];
                    string secondUser = commands[2];
                    if (usersSend.ContainsKey(firstUser) && usersSend.ContainsKey(secondUser))
                    {
                        usersSend[firstUser]++;
                        if (usersSend[firstUser] + usersReceived[firstUser] >= capacity)
                        {
                            usersSend.Remove(firstUser);
                            usersReceived.Remove(firstUser);
                            Console.WriteLine($"{firstUser} reached the capacity!");
                        }

                        usersReceived[secondUser]++;
                        if (usersReceived[secondUser] + usersSend[secondUser] >= capacity)
                        {
                            usersReceived.Remove(secondUser);
                            usersSend.Remove(secondUser);
                            Console.WriteLine($"{secondUser} reached the capacity!");
                        }
                    }
                }
                else if (commands[0] == "Empty")
                {
                    string username = commands[1];
                    if (username == "All")
                    {
                        usersReceived = new Dictionary<string, int>();
                        usersSend = new Dictionary<string, int>();
                    }

                    else
                    {
                        if (usersSend.ContainsKey(username) && usersReceived.ContainsKey(username))
                        {
                            usersReceived.Remove(username);
                            usersSend.Remove(username);
                        }
                    }
                }

                commands = Console.ReadLine().Split("=", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Users count: {usersSend.Count}");
            foreach (var user in usersReceived.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value + usersSend[user.Key]}");
            }
        }
    }
}
