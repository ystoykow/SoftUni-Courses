namespace _05._Decrypting_Message
{
    using System;

    class DecryptingMessage
    {
        public static void Main()
        {
            int decryptKey = int.Parse(Console.ReadLine());
            int charsCount = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < charsCount; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int decryptedChar = currentChar + decryptKey;
                
                result += (char)decryptedChar;
            }
            Console.WriteLine(result);
        }
    }
}
