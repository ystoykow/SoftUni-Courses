using System;

namespace _09._Password_Generator
{
    class PasswordGenerator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {

                for (int j = 1; j < n; j++)
                {

                    for (int k = 97; k < 97 + l; k++)
                    {

                        for (int m = 97; m < 97 + l; m++)
                        {

                            for (int x = 1; x <= n; x++)
                            {

                                if (x > i && x > j)
                                {
                                    Console.Write($"{i}{j}{((char)k)}{((char)m)}{x} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
