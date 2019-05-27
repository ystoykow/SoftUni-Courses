namespace _10._LadyBugs
{
    using System;
    using System.Linq;

    public class LadyBugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugsPosition = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();

            int[] field = new int[fieldSize];
            for (int i = 0; i < bugsPosition.Length; i++)
            {
                int indexOfBug = bugsPosition[i];

                if (indexOfBug < field.Length && indexOfBug >= 0)
                {
                    field[indexOfBug] = 1;
                }
            }
            while (command[0] != "end")
            {
                int fromIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLenght = int.Parse(command[2]);

                if (fromIndex < 0 || fromIndex >= field.Length)
                {
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }
                else if (field[fromIndex] == 0)
                {
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }
                else if (flyLenght == 0)
                {
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }

                if (direction == "right")
                {
                    int startIndex = fromIndex;
                    while (true)
                    {
                        if (fromIndex + flyLenght < field.Length && fromIndex + flyLenght >= 0)
                        {
                            if (field[fromIndex + flyLenght] != 1)
                            {
                                field[fromIndex + flyLenght] = 1;
                                field[startIndex] = 0;
                                break;
                            }
                            else
                            {
                                fromIndex = fromIndex + flyLenght;
                            }
                        }
                        else
                        {
                            field[startIndex] = 0;
                            break;
                        }
                    }
                }
                else if (direction == "left")
                {
                    int startIndex = fromIndex;
                    while (true)
                    {
                        if (fromIndex - flyLenght >= 0 && fromIndex - flyLenght < field.Length)
                        {
                            if (field[fromIndex - flyLenght] != 1)
                            {
                                field[fromIndex - flyLenght] = 1;
                                field[startIndex] = 0;
                                break;
                            }
                            else
                            {
                                fromIndex = fromIndex - flyLenght;
                            }
                        }
                        else
                        {
                            field[startIndex] = 0;
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
