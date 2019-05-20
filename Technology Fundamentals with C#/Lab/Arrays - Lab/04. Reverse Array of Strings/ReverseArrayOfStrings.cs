namespace _04._Reverse_Array_of_Strings
{
    using System;

    class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split();

            Array.Reverse(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i] + " ");
            }
        }
    }
}
