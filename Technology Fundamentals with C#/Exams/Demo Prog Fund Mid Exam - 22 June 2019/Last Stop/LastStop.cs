namespace Last_Stop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LastStop
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Change")
                {
                    int paintingNumber = int.Parse(tokens[1]);
                    int replaceNumber = int.Parse(tokens[2]);

                    if (numbers.Contains(paintingNumber))
                    {
                        int indexOfPaintingNumber = numbers.IndexOf(paintingNumber);
                        numbers[indexOfPaintingNumber] = replaceNumber;
                    }
                }
                else if (command == "Hide")
                {
                    int paintingNumber = int.Parse(tokens[1]);

                    if (numbers.Contains(paintingNumber))
                    {
                        int indexOfPaintingNumber = numbers.IndexOf(paintingNumber);
                        numbers.RemoveAt(indexOfPaintingNumber);
                    }
                }
                else if (command == "Switch")
                {
                    int firstPaintingNumber = int.Parse(tokens[1]);
                    int secondPaintingNumber = int.Parse(tokens[2]);
                    if (numbers.Contains(firstPaintingNumber) && numbers.Contains(secondPaintingNumber))
                    {
                        int indexOfFirstPaintingNumber = numbers.IndexOf(firstPaintingNumber);
                        int indexOfSecondPaintingNumber = numbers.IndexOf(secondPaintingNumber);
                        numbers[indexOfFirstPaintingNumber] = secondPaintingNumber;
                        numbers[indexOfSecondPaintingNumber] = firstPaintingNumber;
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    int paintingNumber = int.Parse(tokens[2]);

                    if (index > -1 && index < numbers.Count - 1)
                    {
                        numbers.Insert(index+1,paintingNumber);
                    }
                }
                else if (command == "Reverse")
                {
                    numbers.Reverse();
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
