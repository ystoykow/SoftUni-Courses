using System;
namespace _04.Inches_to_Centimeters
{
    class InchesToCM
    {
        static void Main()
        {
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine("{0:0.00}", cm);
        }
    }
}
