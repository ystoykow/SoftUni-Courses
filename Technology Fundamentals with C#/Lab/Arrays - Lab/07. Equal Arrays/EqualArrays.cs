namespace _07._Equal_Arrays
{
    using System;
    using System.Linq;

    class EqualArrays
    {
       public static void Main()
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int diff = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    sum += firstArr[i];

                }
                else if (firstArr[i] != secondArr[i])
                {
                    diff = i;
                    break;
                }
            }
            if (sum > 0 && diff == 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diff} index");
            }
        }
    }
}
