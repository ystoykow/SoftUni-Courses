namespace _11._Array_Manipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] manipulation = command.Split().ToArray();

                if (manipulation[0] == "exchange")
                {
                    int indexOfExchange = int.Parse(manipulation[1]);

                    if (indexOfExchange > numbers.Length - 1 || indexOfExchange < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] result = Exchange(numbers, indexOfExchange);
                        numbers = result;
                    }
                }
                else if (manipulation[0] == "max")
                {
                    if (manipulation[1] == "odd")
                    {
                        PrintMax(numbers, 1);
                    }
                    else if (manipulation[1] == "even")
                    {
                        PrintMax(numbers, 0);
                    }
                }
                else if (manipulation[0] == "min")
                {
                    if (manipulation[1] == "odd")
                    {
                        PrintMin(numbers, 1);
                    }
                    else if (manipulation[1] == "even")
                    {
                        PrintMin(numbers, 0);
                    }
                }
                else if (manipulation[0] == "first")
                {
                    if (manipulation[2] == "odd")
                    {
                        int countNumbers = int.Parse(manipulation[1]);
                        PrintFirst(numbers, countNumbers, 1);
                    }
                    else if (manipulation[2] == "even")
                    {
                        int countNumbers = int.Parse(manipulation[1]);
                        PrintFirst(numbers, countNumbers, 0);
                    }
                }
                else if (manipulation[0] == "last")
                {
                    if (manipulation[2] == "odd")
                    {
                        int countNumbers = int.Parse(manipulation[1]);
                        PrintLast(numbers, countNumbers, 1);
                    }
                    else if (manipulation[2] == "even")
                    {
                        int countNumbers = int.Parse(manipulation[1]);
                        PrintLast(numbers, countNumbers, 0);
                    }
                }

                command = Console.ReadLine();
            }

            PrintNumbers(numbers, numbers.Length);
        }
        public static int[] Exchange(int[] array, int n)
        {
            int j = 0;
            int l = 0;
            int[] secondArray = new int[array.Length];

            for (int i = n + 1; i < array.Length; i++)
            {
                secondArray[j] = array[i];
                j++;
            }
            for (int i = j; i < array.Length; i++)
            {
                secondArray[i] = array[l];
                l++;
            }
            return secondArray;
        }
        public static void PrintMax(int[] array, int n)
        {
            int maxNumber = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == n)
                {
                    if (array[i] >= maxNumber)
                    {
                        maxNumber = array[i];
                        index = i;
                    }
                }
            }

            PrintIndex(index);
        }
        public static void PrintMin(int[] array, int n)
        {
            int minNumber = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == n)
                {
                    if (array[i] <= minNumber)
                    {
                        minNumber = array[i];
                        index = i;
                    }
                }
            }

            PrintIndex(index);
        }
        public static void PrintIndex(int index)
        {
            if (index >= 0)
            {
                Console.WriteLine($"{index}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        public static void PrintFirst(int[] array, int count, int n)
        {
            int[] countedNumbers = new int[count];
            int j = 0;
            if (count > array.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == n)
                    {
                        countedNumbers[j] = array[i];
                        j++;
                    }

                    if (j == countedNumbers.Length)
                    {
                        break;
                    }
                }

                int[] numbers = new int[j];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = countedNumbers[i];
                }

                PrintNumbers(numbers, j);
            }
        }
        public static void PrintLast(int[] array, int count, int n)
        {
            int[] countedNumbers = new int[count];
            int j = 0;

            if (count > array.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == n)
                    {
                        countedNumbers[j] = array[i];
                        j++;
                    }

                    if (j == countedNumbers.Length)
                    {
                        break;
                    }
                }

                int[] numbers = new int[j];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = countedNumbers[i];
                }
                Array.Reverse(numbers);

                PrintNumbers(numbers, j);
            }
        }
        public static void PrintNumbers(int[] numbers, int length)
        {
            if (length > 0)
            {
                Console.WriteLine($"[{string.Join(", ", numbers)}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
    }
}