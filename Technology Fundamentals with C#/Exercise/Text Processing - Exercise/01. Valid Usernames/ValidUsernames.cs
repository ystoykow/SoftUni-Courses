namespace _01._Valid_Usernames
{
    using System;
    using System.Collections.Generic;

    public class ValidUsernames
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentUser = input[i];
                if (currentUser.Length >= 3 && currentUser.Length <= 16)
                {
                    bool ValidateContent = ValidateUsernameContent(currentUser);
                    if (ValidateContent)
                    {
                        validUsernames.Add(currentUser);
                    }
                }
            }

            foreach (var username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }

        public static bool ValidateUsernameContent(string currentUser)
        {
            foreach (char ch in currentUser)
            {
                if (!char.IsLetterOrDigit(ch) && ch != '_' && ch != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}