using System;

namespace _04._Number_sequence
{
    class NumberSequence
    {
        static void Main()
        {
            string command = Console.ReadLine();

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            while (command != "END")
            {
                int input = int.Parse(command);

                if (input < minNum)
                {
                    minNum = input;
                }
                if (input > maxNum)
                {
                    maxNum = input;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
