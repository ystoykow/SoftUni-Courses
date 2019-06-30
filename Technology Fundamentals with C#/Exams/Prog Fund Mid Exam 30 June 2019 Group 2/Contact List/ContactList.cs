namespace Contact_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ContactList
    {
        public static void Main()
        {
            List<string> contacts = Console.ReadLine().Split().ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Add")
                {
                    string contact = command[1];
                    int index = int.Parse(command[2]);
                    if (!contacts.Contains(contact))
                    {
                        contacts.Add(contact);
                    }
                    else if (index >= 0 && index <= contacts.Count)
                    {
                        contacts.Insert(index, contact);
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if (command[0] == "Export")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    int min = Math.Min(count, contacts.Count - startIndex);
                    for (int i = 0; i < min; i++)
                    {
                        Console.Write($"{contacts[i + startIndex]} ");
                    }

                    Console.WriteLine();
                }
                else if (command[0] == "Print")
                {
                    if (command[1] == "Reversed")
                    {
                        contacts.Reverse();
                    }

                    Console.Write($"Contacts: ");
                    Console.WriteLine(string.Join(" ", contacts));
                    break;
                }
            }
        }
    }
}
