namespace _04._Printing_Triangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            MakeTriangle(input);
        }
        public static void MakeTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+ " ");
                }

                Console.WriteLine();
            }
            for (int i = number-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}
