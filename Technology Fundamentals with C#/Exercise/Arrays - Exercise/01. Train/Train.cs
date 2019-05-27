namespace _01._Train
{
    using System;

    public class Train
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] persons = new int[n];
            int sum = 0;

            for (int i = 0; i < persons.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
                persons[i] = number;
            }

            Console.WriteLine(string.Join(" ", persons));
            Console.WriteLine(sum);
        }
    }
}
