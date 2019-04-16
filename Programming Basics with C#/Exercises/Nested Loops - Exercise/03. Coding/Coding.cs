using System;

namespace _03._Coding
{
    class Coding
    {
        static void Main()
        {
            string number = Console.ReadLine();

            int numb = int.Parse(number);

            for (int i = number.Length; i > 0; i--)
            {

                while (numb>0)
                {

                    int lastDigit = numb % 10;

                    for (int j = 1; j <= lastDigit; j++)
                    {

                        if (lastDigit !=0)
                        {
                            Console.Write((char)(lastDigit + 33));
                        }
                    }

                    if (lastDigit==0)
                    {
                        Console.Write("ZERO");
                    }

                    Console.WriteLine();

                    numb /= 10;
                }
            }
        }
    }
}
