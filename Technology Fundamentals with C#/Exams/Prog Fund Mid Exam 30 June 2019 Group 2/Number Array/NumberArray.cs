namespace Number_Array
{
    using System;
    using System.Linq;

    public class NumberArray
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "End")
            {
                if (commands[0] == "Switch")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < numbers.Length)
                    {
                        numbers[index] = numbers[index] * -1;
                    }
                }
                else if (commands[0] == "Change")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < numbers.Length)
                    {
                        int value = int.Parse(commands[2]);
                        numbers[index] = value;
                    }
                }
                else if (commands[0] == "Sum")
                {
                    if (commands[1] == "Negative")
                    {
                        Console.WriteLine(numbers.Where(x => x <= 0).Sum());
                    }
                    else if (commands[1] == "Positive")
                    {

                        Console.WriteLine(numbers.Where(x => x >= 0).Sum());
                    }
                    else
                    {
                        Console.WriteLine(numbers.Sum());
                    }
                }

                commands = Console.ReadLine().Split();
            }

            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}