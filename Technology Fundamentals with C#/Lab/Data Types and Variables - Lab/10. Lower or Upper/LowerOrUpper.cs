namespace _10._Lower_or_Upper
{
    using System;

    class LowerOrUpper
    {
        static void Main()
        {
            char character = char.Parse(Console.ReadLine());
            if ((int)character <= 90 && (int)character >= 65)
            {
                Console.WriteLine("upper-case");

            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
