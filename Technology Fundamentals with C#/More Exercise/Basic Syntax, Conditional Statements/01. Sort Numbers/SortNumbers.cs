namespace _01._Sort_Numbers
{
    using System;

    class SortNumbers
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if (numberOne >= numberTwo && numberOne >= numberThree)
            {
                Console.WriteLine(numberOne);
                if(numberTwo>=numberThree)
                {
                    Console.WriteLine(numberTwo);
                    Console.WriteLine(numberThree);
                }
                else
                {
                    Console.WriteLine(numberThree);
                    Console.WriteLine(numberTwo);
                }
            }
            else if (numberTwo >= numberOne && numberTwo >= numberThree)
            {
                Console.WriteLine(numberTwo);
                if (numberOne >= numberThree)
                {
                    Console.WriteLine(numberOne);
                    Console.WriteLine(numberThree);
                }
                else
                {
                    Console.WriteLine(numberThree);
                    Console.WriteLine(numberOne);
                }
            }
            else
            {
                Console.WriteLine(numberThree);
                if (numberTwo >= numberOne)
                {
                    Console.WriteLine(numberTwo);
                    Console.WriteLine(numberOne);
                }
                else
                {
                    Console.WriteLine(numberOne);
                    Console.WriteLine(numberTwo);
                }
            }
        }
    }
}
