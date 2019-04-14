using System;

namespace _08._Equal_Words
{
    class EqualWords
    {
        static void Main()
        {
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();
            wordOne = wordOne.ToLower();
            wordTwo = wordTwo.ToLower();
            if (wordTwo == wordOne)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
