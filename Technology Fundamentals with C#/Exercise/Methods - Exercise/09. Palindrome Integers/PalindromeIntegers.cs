namespace _09._Palindrome_Integers
{
    using System;

    public class PalindromeIntegers
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                bool result = IsPalindrome(command);

                if (result)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
        }
        public static bool IsPalindrome(string a)
        {
            bool result = false;
            string first = a;
            string second = string.Empty;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                second += a[i];
            }

            int comparison = first.CompareTo(second);

            if (comparison == 0)
            {
                result = true;
            }

            return result;
        }
    }
}
