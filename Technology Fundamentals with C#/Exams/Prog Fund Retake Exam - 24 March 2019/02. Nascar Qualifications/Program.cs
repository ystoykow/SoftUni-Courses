using System;
using System.Linq;

namespace _02._Nascar_Qualifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var racer = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "Race")
                {
                    if (!racer.Contains(tokens[1]))
                    {
                        racer.Add(tokens[1]);
                    }

                }
                else if (tokens[0] == "Accident")
                {
                    if (racer.Contains(tokens[1]))
                    {
                        racer.Remove(tokens[1]);
                    }
                }
                else if (tokens[0] == "Box")
                {
                    if (racer.Contains(tokens[1]))
                    {
                        int indexOf = racer.IndexOf(tokens[1]);
                        if (indexOf + 1 < racer.Count)
                        {
                            racer.Remove(tokens[1]);
                            racer.Insert(indexOf + 1, tokens[1]);
                        }
                    }
                }
                else if (tokens[0] == "Overtake")
                {
                    if (racer.Contains(tokens[1]))
                    {
                        int indexOf = racer.IndexOf(tokens[1]);

                        if (indexOf+1 - int.Parse(tokens[2]) > 0)
                        {
                            racer.Remove(tokens[1]);
                            racer.Insert(indexOf+ - int.Parse(tokens[2]), tokens[1]);
                        }
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ~ ",racer));
        }
    }
}
