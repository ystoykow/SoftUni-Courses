namespace _05._Digits__Letters_and_Other
{
    using System;

    public class DigitsLettersAndOther
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;
            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                else
                {
                    other += ch;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
