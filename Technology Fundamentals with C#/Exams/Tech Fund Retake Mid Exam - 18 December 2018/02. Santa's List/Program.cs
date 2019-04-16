using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> badKids = Console.ReadLine().Split('&').ToList();
            string command = Console.ReadLine();
            while (command!="Finished!")
            {
                string[] tokens = command.Split();
                if (tokens[0]=="Bad")
                {
                    if (!badKids.Contains(tokens[1]))
                    {
                        badKids.Insert(0,tokens[1]);
                    }
                }
                else if (tokens[0]=="Good")
                {
                    if(badKids.Contains(tokens[1]))
                    {
                        badKids.Remove(tokens[1]);
                    }
                }
                else if (tokens[0]=="Rename")
                {
                    if (badKids.Contains(tokens[1]))
                    {
                        int indexOfRename = badKids.IndexOf(tokens[1]);
                        badKids.Insert(indexOfRename, tokens[2]);
                        badKids.Remove(tokens[1]);
                    }
                }
                else if (tokens[0]=="Rearrange")
                {
                    if (badKids.Contains(tokens[1]))
                    {
                        badKids.Remove(tokens[1]);
                        badKids.Add(tokens[1]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",badKids));
        }
    }
}
