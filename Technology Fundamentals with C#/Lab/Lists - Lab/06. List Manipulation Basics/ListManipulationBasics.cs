namespace _06._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class ListManipulationBasics
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split();

            int count = 0;

            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);
                    count++;
                }
                else if (commands[0] == "Remove")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Remove(number);
                    count++;
                }
                else if (commands[0] == "RemoveAt")
                {
                    int number = int.Parse(commands[1]);
                    numbers.RemoveAt(number);
                    count++;
                }
                else if (commands[0] == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    numbers.Insert(index, number);
                    count++;
                }

                commands = Console.ReadLine().Split();
            }

            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
