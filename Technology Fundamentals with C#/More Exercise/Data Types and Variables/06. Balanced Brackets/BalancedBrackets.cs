namespace _06._Balanced_Brackets
{
    using System;

    class BalancedBrackets
    {
        public static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());

            int count = 0;
            bool isBalanced = true;

            for (int i = 0; i < inputLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    count++;
                }
                else if (input == ")")
                {
                    count--;
                }

                if (count > 1 || count < 0)
                {
                    isBalanced = false;
                }
            }

            if (isBalanced && count==0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
