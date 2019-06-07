namespace _02._Vowels_Count
{
    using System;

   public class VowelsCount
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            
            Console.WriteLine(VowelCounter(text));

        }
        public static string VowelCounter(string text)
        {
            int count = 0;
            foreach (var c in text)
            {
                if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
                {
                    count++;
                }
            }

            string result = count.ToString();

            return result;
        }
    }
}
