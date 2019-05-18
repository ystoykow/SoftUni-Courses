    namespace _05._Login
    {
        using System;

        class Login
        {
            static void Main()
            {
                string login = Console.ReadLine();

                int counter = 0;
                string correctLogin = string.Empty;
                bool isLoged = false;

                for (int i = login.Length - 1; i >= 0; i--)
                {
                    correctLogin += login[i];
                }

                while (true)
                {
                    counter++;
                    string input = Console.ReadLine();

                    if (input == correctLogin)
                    {
                        isLoged = true;
                        break;
                    }
                    else if (counter == 4)
                    {
                        Console.WriteLine($"User {login} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }

                if (isLoged)
                {
                    Console.WriteLine($"User {login} logged in.");
                }
            }
        }
    }
