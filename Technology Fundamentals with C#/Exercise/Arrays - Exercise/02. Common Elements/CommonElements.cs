namespace _02._Common_Elements
{
    using System;

    public class CommonElements
    {
        public static void Main()
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            string common = string.Empty;

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (first[j] == second[i])
                    {
                        common += first[j] + " ";
                    }
                }
            }

            Console.WriteLine(common);
        }
    }
}
