using System;

namespace _04._Password_Validator
{
    class PasswordValidator
    {
        public static void Main()
        {
            string password = Console.ReadLine();
            Validate(password);
        }
        public static bool ValidateLenght(string text)
        {
            bool result = false;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                count++;
            }
            if (count < 6 || count > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                result = true;
            }

            return result;
        }
        public static bool ValidateSymbols(string text)
        {
            bool result;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 48 && text[i] <= 57) || (text[i] >= 65 && text[i] <= 90) || (text[i] >= 97 && text[i] <= 122))
                {
                    count++;
                }
            }
            if (count == text.Length)
            {
                result = true;
            }
            else
            {
                result = false;
                Console.WriteLine($"Password must consist only of letters and digits");
            }

            return result;
        }
        public static bool ValidateDigits(string text)
        {
            bool result;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                result = true;
            }
            else
            {
                result = false;
                Console.WriteLine($"Password must have at least 2 digits");
            }

            return result;
        }
        public static void Validate(string text)
        {
            bool one = ValidateLenght(text);
            bool two = ValidateSymbols(text);
            bool three = ValidateDigits(text);
            if (one && two && three)
            {
                Console.WriteLine($"Password is valid");
            }
        }
    }
}
