using System;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            int santaPosition = 0;
            string command = Console.ReadLine();
            while (command != "Merry Xmas!")
            {
                string[] tokens = command.Split();
                int jumpLenght = int.Parse(tokens[1]);
                if (santaPosition + jumpLenght%field.Length < field.Length)
                {
                    santaPosition = santaPosition + jumpLenght%field.Length;
                    if (field[santaPosition] > 0)
                    {
                        field[santaPosition] -= 2;
                    }
                    else
                    {
                        Console.WriteLine($"House {santaPosition} will have a Merry Christmas.");
                    }

                }
                else
                {
                    int diff = santaPosition + jumpLenght%field.Length - (field.Length-1);
                    santaPosition=-1+diff;
                    if (field[santaPosition] > 0)
                    {
                        field[santaPosition] -= 2;
                    }
                    else
                    {
                        Console.WriteLine($"House {santaPosition} will have a Merry Christmas.");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Santa's last position was {santaPosition}.");
            int count = 0;
            foreach (var item in field)
            {
                if (item>0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {count} houses.");
            }


        }
    }
}
