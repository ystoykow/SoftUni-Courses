using System;

namespace _06._Number_100to200
{
    class NumberRange100to200
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number <100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number>= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
