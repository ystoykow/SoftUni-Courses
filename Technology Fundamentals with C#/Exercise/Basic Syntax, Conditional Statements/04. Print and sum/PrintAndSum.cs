namespace _04._Print_and_sum
{
    using System;

    class PrintAndSum
    {
        static void Main()
        {
            int startingNumb = int.Parse(Console.ReadLine());
            int endingNumb = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startingNumb; i <= endingNumb; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
