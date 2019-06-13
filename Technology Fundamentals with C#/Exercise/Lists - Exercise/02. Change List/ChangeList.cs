namespace _02._Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChangeList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    numbers.RemoveAll(x=>x==number);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
