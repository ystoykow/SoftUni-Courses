using System;
namespace _01._USD_to_BGN
{
    class USDtoBGN
    {
        static void Main()
        {
            double USD = double.Parse(Console.ReadLine());

            double BGN = Math.Round(USD * 1.79549, 2);

            Console.WriteLine($"{BGN:0.00}");
        }
    }
}
