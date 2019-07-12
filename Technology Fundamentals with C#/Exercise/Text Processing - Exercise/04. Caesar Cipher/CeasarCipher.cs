namespace _04._Caesar_Cipher
{
    using System;

    public class CeasarCipher
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string encryptedText = EncryptText(text);
            Console.WriteLine(encryptedText);
        }

        public static string EncryptText(string text)
        {
            string encryptedText = string.Empty;
            foreach (char symbol in text)
            {
                int newSymbol = symbol + 3;
                encryptedText += (char)newSymbol;
            }

            return encryptedText;
        }
    }
}