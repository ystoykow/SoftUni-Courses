using System;

namespace _01._Matrix
{
    class Matrix
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {

                for (int j = a; j <= b; j++)
                {

                    for (int k = c; k <= d; k++)
                    {

                        for (int l = c; l <= d; l++)
                        {

                            if (i + k == j + l && i != j && k != l)
                            {
                                Console.WriteLine($"{i}{j}");
                                Console.WriteLine($"{l}{k}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
