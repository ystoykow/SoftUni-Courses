namespace _04._Refactoring_Prime_Checker
{
    using System;

    class RefactoringPrimeChecker
    {
        public static void Main()
        {
            int numbersTo= int.Parse(Console.ReadLine());
            for (int i = 2; i <= numbersTo; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}
