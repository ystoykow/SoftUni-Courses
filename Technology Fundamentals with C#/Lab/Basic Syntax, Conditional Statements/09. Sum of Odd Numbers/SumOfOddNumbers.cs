namespace _09._Sum_of_Odd_Numbers
{
    using System;

    class SumOfOddNumbers
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int i = 0;

            while (count != 0)
            {
                if (i%2!=0)
                {
                    sum += i;
                    count--;
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
