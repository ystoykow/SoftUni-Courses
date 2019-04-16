using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var paintNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split();
                var command = tokens[0];
                if (command == "Change")
                {
                    var firstNumb = int.Parse(tokens[1]);
                    var secondNumb = int.Parse(tokens[2]);
                    if (paintNumbers.Contains(firstNumb))
                    {
                        var indexOf = paintNumbers.IndexOf(firstNumb);
                        paintNumbers.Insert(indexOf,secondNumb);
                        paintNumbers.RemoveAt(indexOf + 1);
                    }

                }
                else if (command == "Hide")
                {
                    var numb = int.Parse(tokens[1]);
                    if (paintNumbers.Contains(numb))
                    {
                        paintNumbers.Remove(numb);
                    }

                }
                else if (command == "Switch")
                {
                    var firstNumb = int.Parse(tokens[1]);
                    var secondNumb = int.Parse(tokens[2]);
                    if (paintNumbers.Contains(firstNumb) && paintNumbers.Contains(secondNumb))
                    {
                        var indexOfFirst = paintNumbers.IndexOf(firstNumb);
                        var indexOfSecond = paintNumbers.IndexOf(secondNumb);
                        paintNumbers.Insert(indexOfFirst, secondNumb);
                        paintNumbers.RemoveAt(indexOfFirst + 1);
                        paintNumbers.Insert(indexOfSecond, firstNumb);
                        paintNumbers.RemoveAt(indexOfSecond + 1);
                    }

                }
                else if (command == "Insert")
                {
                    var index = int.Parse(tokens[1]);
                    var number = int.Parse(tokens[2]);
                    if (paintNumbers.Count>index+1)
                    {
                        paintNumbers.Insert(index + 1, number);
                    }


                }
                else if (command == "Reverse")
                {
                    paintNumbers.Reverse();
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", paintNumbers));

        }
    }
}
