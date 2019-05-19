namespace _07._Concat_Names
{
    using System;

    class ConcatNames
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string symbols = Console.ReadLine();
            Console.WriteLine($"{firstName}{symbols}{lastName}");
        }
    }
}
