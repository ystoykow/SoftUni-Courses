using System;

namespace _06._Challenge_the_Wedding
{
    class ChallengeTheWedding
    {
        static void Main()
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tabbles = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 1; i <= men; i++)
            {

                for (int k = 1; k <= women; k++)
                {

                    if (tabbles > total)
                    {
                        Console.Write("({0} <-> {1}) ", i, k);

                        total++;
                    }
                }
            }
        }
    }
}
