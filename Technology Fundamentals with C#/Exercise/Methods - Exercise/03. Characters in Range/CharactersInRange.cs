namespace _03._Characters_in_Range
{
    using System;

    public class CharactersInRange
    {
        public static void Main()
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            
            string result = CharsInRange(one, two);
            Console.WriteLine($"{result}");
        }
        public static string CharsInRange(char a,char b)
        {
            char first = GetMax(a, b);
            char second = GetMin(a, b);
            string result = string.Empty;

            for (int i =second+1 ; i < first; i++)
            {
                result += (char)i + " ";
            }

            return result;
        }
        public static char GetMax(char a, char b)
        {
            char result;
            if (a>b)
            {
                result = a;
            }
            else
            {
                result = b;
            }

            return result;
        }
        public static char GetMin(char a,char b)
        {
            char result;
            if (a<b)
            {
                result = a;
            }
            else
            {
                result = b;
            }

            return result;
        }
    }
}
