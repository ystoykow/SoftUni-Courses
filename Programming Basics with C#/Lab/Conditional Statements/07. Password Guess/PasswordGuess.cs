using System;

namespace _07._Password_Guess
{
    class PasswordGuess
    {
        static void Main()
        {
            string password = "s3cr3t!P@ssw0rd";
            string accountPassword = Console.ReadLine();
            if (accountPassword == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
