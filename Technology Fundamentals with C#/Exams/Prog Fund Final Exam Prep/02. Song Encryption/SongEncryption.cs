namespace _02._Song_Encryption
{
    using System;
    using System.Text.RegularExpressions;

    public class SongEncryption
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"^(?<artist>[A-Z][a-z' ]+):[?<song>[A-Z ]+$";
            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    string artist = Regex.Match(input, pattern).Groups["artist"].Value;
                    string encryptedMessage = string.Empty;
                    for (int i = 0; i < input.Length; i++)
                    {
                        int encryptKey = artist.Length;

                        if (char.IsUpper(input[i]))
                        {
                            while (input[i] + encryptKey > 90)
                            {
                                encryptKey -= 26;
                            }

                            encryptedMessage +=(char)(input[i] + encryptKey);
                        }
                        else if (input[i] ==' ' || input[i]=='\'')
                        {
                            encryptedMessage += input[i];
                        }
                        else if (input[i] == ':')
                        {
                            encryptedMessage += "@";
                        }
                        else
                        {
                            while(input[i] + encryptKey > 122)
                            {
                                encryptKey -= 26;
                            }

                            encryptedMessage += (char)(input[i] + encryptKey);
                        }
                    }

                    Console.WriteLine($"Successful encryption: {encryptedMessage}");
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
