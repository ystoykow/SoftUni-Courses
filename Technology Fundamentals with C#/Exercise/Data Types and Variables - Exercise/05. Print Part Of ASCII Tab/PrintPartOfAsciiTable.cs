namespace _05._Print_Part_Of_ASCII_Tab
{
    using System;

    class PrintPartOfAsciiTable
    {
        static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
