namespace _05._Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
       public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = specialNumbers[0];
            int bombPower = specialNumbers[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    for (int j = 0; j < bombPower; j++)
                    {
                        if (i - 1 >= 0)
                        {
                            numbers.RemoveAt(i - 1);
                            i--;
                        }

                        if (i + 1 < numbers.Count)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                    }

                    numbers.Remove(bombNumber);
                    i = -1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
