using System;

namespace _01._Old_Books
{
    class OldBooks
    {
        static void Main()
        {
            string searchedBook = Console.ReadLine();
            int libaryCap = int.Parse(Console.ReadLine());

            int count = 0;

            while (count<libaryCap)
            {
                string bookName = Console.ReadLine();

                if (bookName == searchedBook)
                {
                    break;
                }

                count++;
            }

            if (count== libaryCap)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            else
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
        }
    }
}
