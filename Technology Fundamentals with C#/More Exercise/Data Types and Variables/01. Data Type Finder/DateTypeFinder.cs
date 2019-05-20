namespace _01._Data_Type_Finder
{
    using System;

    class DateTypeFinder
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isInteger = int.TryParse(input, out int inputAsInteger);
                bool isDouble = double.TryParse(input, out double inputAsDouble);
                bool isChar = char.TryParse(input, out char inputAsChar);
                bool isBool = bool.TryParse(input, out bool inputAsBool);

                if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }


                input = Console.ReadLine();
            }
        }
    }
}
