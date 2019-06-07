namespace _07._NxN_Matrix
{
    using System;

    public class NxNMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            MakeMatrixN(n);
        }
        public static void MakeMatrixN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
