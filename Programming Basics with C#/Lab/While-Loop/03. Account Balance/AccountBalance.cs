using System;

namespace _03._Account_Balance
{
    class AccountBalance
    {
        static void Main()
        {
            int pays = int.Parse(Console.ReadLine());

            int count = 0;
            double sum = 0;

            while (count < pays)
            {
                double fee = double.Parse(Console.ReadLine());

                if (fee <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                count++;
                sum += fee;

                Console.WriteLine($"Increase: {fee:f2}");
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
