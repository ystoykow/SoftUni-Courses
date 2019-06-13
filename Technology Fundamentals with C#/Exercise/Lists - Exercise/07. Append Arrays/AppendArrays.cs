namespace _07._Append_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendArrays
    {
        public static void Main()
        {
            List<string> numbersAsText = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            List<string> appendNumbers = new List<string>();
            foreach (var str in numbersAsText)
            {
                appendNumbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            Console.WriteLine(string.Join(" ", appendNumbers));
        }
    }
}
