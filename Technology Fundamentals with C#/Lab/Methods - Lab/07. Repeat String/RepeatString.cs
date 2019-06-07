namespace _07._Repeat_String
{
    using System;

    public class RepeatString
    {
        public static void Main()
        {
            string someString = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            
            Console.WriteLine(RepeatSomeString(someString, count));
        }
        public static string RepeatSomeString(string text,int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
