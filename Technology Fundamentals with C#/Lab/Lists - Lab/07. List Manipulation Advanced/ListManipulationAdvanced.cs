namespace _07._List_Manipulation_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListManipulationAdvanced
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split();
            int count = 0;
            while (commands[0] != "end")
            {
                if (commands[0] == "Contains")
                {
                    int number = int.Parse(commands[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commands[0] == "PrintEven")
                {
                    PrintEvenOrOdd(numbers, 0);
                }
                else if (commands[0] == "PrintOdd")
                {
                    PrintEvenOrOdd(numbers, 1);
                }
                else if (commands[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (commands[0] == "Filter")
                {
                    int indexNumber = int.Parse(commands[2]);
                    Filter(numbers, commands[1], indexNumber);
                }
                else if (commands[0] == "Add")
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

        public static void PrintEvenOrOdd(List<int> num, int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % 2 == n)
                {
                    result.Add(num[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public static void Filter(List<int> num, string symbol, int number)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < num.Count; i++)
            {
                if (symbol == "<")
                {
                    if (num[i] < number)
                    {
                        result.Add(num[i]);
                    }
                }
                else if (symbol == ">")
                {
                    if (num[i] > number)
                    {
                        result.Add(num[i]);
                    }
                }
                else if (symbol == ">=")
                {
                    if (num[i] >= number)
                    {
                        result.Add(num[i]);
                    }
                }
                else if (symbol == "<=")
                {
                    if (num[i] <= number)
                    {
                        result.Add(num[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
