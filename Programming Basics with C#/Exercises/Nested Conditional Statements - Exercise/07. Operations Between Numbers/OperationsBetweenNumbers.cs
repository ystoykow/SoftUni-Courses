using System;

namespace _07._Operations_Between_Numbers
{
    class OperationsBetweenNumbers
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double answer = 0;
            string evenOdd = string.Empty;

            if (symbol == '+')
            {
                answer = numberOne + numberTwo;
                if (answer % 2 == 0)
                {
                    evenOdd += "even";
                }
                else
                {
                    evenOdd += "odd";
                }

                Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {answer} - {evenOdd}");
            }
            else if (symbol == '-')
            {
                answer = numberOne - numberTwo;
                if (answer % 2 == 0)
                {
                    evenOdd += "even";
                }
                else
                {
                    evenOdd += "odd";
                }

                Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {answer} - {evenOdd}");
            }
            else if (symbol == '*')
            {
                answer = numberOne * numberTwo;
                if (answer % 2 == 0)
                {
                    evenOdd += "even";
                }
                else
                {
                    evenOdd += "odd";
                }

                Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {answer} - {evenOdd}");
            }
            else if (symbol == '/')
            {
                if (numberTwo != 0)
                {
                    answer = (double)numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {answer:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
            }
            else if (symbol == '%')
            {
                if (numberTwo != 0)
                {
                    answer = (double)numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {answer}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
            }
        }
    }
}
