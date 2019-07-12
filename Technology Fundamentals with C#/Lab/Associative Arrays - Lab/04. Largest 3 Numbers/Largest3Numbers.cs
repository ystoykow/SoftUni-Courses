namespace _04._Largest_3_Numbers
{
    using System;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}