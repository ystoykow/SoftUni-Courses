namespace _09._Pokemon_Don_t_Go
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonDontGo
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sum = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = int.Parse(Console.ReadLine());
                int number = 0;
                if (index >= 0 && index < numbers.Count)
                {
                    number = numbers[index];
                    sum.Add(number);
                    numbers.RemoveAt(index);
                }
                else if (index < 0)
                {
                    number = numbers[0];
                    sum.Add(number);
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                }
                else if (index >= numbers.Count)
                {
                    number = numbers[numbers.Count - 1];
                    sum.Add(number);
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(numbers.Count, numbers[0]);
                }

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[j] > number)
                    {
                        numbers[j] -= number;
                    }
                    else
                    {
                        numbers[j] += number;
                    }
                }

                i = -1;
            }

            Console.WriteLine(sum.Sum());
        }
    }
}
