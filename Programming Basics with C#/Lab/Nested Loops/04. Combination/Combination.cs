using System;

namespace _04._Combination
{
    class Combination
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        for (int l = 0; l <= n; l++)
                        {
                            for (int m = 0; m <= n; m++)
                            {
                                if (j+k+l+m+i==n)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
