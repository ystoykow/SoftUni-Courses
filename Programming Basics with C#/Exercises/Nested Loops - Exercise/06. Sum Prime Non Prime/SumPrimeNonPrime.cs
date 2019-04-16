using System;

namespace _06._Sum_Prime_Non_Prime
{
    class SumPrimeNonPrime
    {
        static void Main()
        {
            string command = Console.ReadLine();

            int sumPrimeNumbers = 0;
            int sumNonPrimeNumbes = 0;

            while (command != "stop")
            {
                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");

                    command = Console.ReadLine();

                    continue;
                }

                bool isPrime = true;

                if (number == 1)
                {
                    isPrime = false;
                }
                else
                {

                    for (int i = number; i >= 2; i--)
                    {

                        if (number % i == 0 && i != number)
                        {
                            isPrime = false;

                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    sumPrimeNumbers += number;
                }
                else
                {
                    sumNonPrimeNumbes += number;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbes}");
        }
    }
}
