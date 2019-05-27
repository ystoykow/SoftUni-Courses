namespace _01._Encrypt__Sort_and_Print
{
    using System;

    public class EncryptSortAndPrint
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] text = new string[n];
            int[] sum = new int[n];

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }
            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];

                foreach (var c in word)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        sum[i] += ((int)c * word.Length);
                    }
                    else
                    {
                        sum[i] += ((int)c / word.Length);
                    }
                }
            }

            Array.Sort(sum);

            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
