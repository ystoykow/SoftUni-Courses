namespace _09._Chars_to_String
{
    using System;

    class CharsToString
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            string result = first.ToString() + second.ToString() + third.ToString();
            Console.WriteLine(result);
        }
    }
}
