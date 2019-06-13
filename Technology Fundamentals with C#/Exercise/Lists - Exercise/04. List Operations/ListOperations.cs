namespace _04._List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOperations
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index < numbers.Count && index >= 0)
                    {
                        numbers.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index < numbers.Count && index >= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        int count = int.Parse(command[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNumber);
                        }
                    }
                    else
                    {
                        int count = int.Parse(command[2]);
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNumber);
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
