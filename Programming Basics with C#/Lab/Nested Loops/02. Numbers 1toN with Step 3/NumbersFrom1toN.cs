using System;

namespace _02._Numbers_1toN_with_Step_3
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
