namespace _12._Even_Number
{
    using System;

    class EvenNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            while(number%2!=0)
            {
                Console.WriteLine("Please write an even number.");

                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
