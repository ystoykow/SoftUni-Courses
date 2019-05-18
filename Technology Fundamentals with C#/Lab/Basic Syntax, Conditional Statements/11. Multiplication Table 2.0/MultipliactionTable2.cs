namespace _11._Multiplication_Table_2._0
{
    using System;

    class MultipliactionTable2
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int startFrom = int.Parse(Console.ReadLine());
            if (startFrom > 10)
            {
                Console.WriteLine($"{number} X {startFrom} = {number * startFrom}");
            }
            else
            {
                for (int i = startFrom; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
        }
    }
}
