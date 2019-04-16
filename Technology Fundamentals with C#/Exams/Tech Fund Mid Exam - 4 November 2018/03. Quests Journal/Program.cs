using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split('-');
            while(command[0]!="Retire!")
            {
                string first = command[0].Trim();
                string second = command[1].Trim();
                if (first == "Start")
                {
                    if (!journal.Contains(second))
                    {
                        journal.Add(second);
                    }
                }
                else if (first == "Complete")
                {
                    if (journal.Contains(second))
                    {
                        journal.Remove(second);
                    }
                }
                else if (first == "Side Quest")
                {
                    string[] quests = second.Split(':');
                    if (journal.Contains(quests[0]) && !journal.Contains(quests[1]))
                    {
                        int indexOfQuest = journal.IndexOf(quests[0]);
                        journal.Insert(indexOfQuest + 1, quests[1]);
                    }
                }
                else if (first == "Renew")
                {
                    if (journal.Contains(second))
                    {
                        journal.Remove(second);
                        journal.Add(second);
                    }
                }
                command = Console.ReadLine().Split('-');
            }
            Console.WriteLine(string.Join(", ",journal));
        }
    }
}
