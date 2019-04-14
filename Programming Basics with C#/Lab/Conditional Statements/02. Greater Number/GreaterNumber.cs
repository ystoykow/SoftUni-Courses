using System;

namespace _02._Greater_Number
{
    class GreaterNumber
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            if (numberOne>numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }
        }
    }
}
