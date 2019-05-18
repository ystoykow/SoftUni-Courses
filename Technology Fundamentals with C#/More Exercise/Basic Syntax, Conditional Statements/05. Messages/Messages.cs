namespace _05._Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Messages
    {
        static void Main()
        {
            int charCount = int.Parse(Console.ReadLine());

            string counter = "2";

            var phoneKeys = new Dictionary<int, char>();
            phoneKeys.Add(0,' ');

            for (int i = 97; i <= 122; i++)
            {
                phoneKeys.Add(int.Parse(counter), (char)i);

                int currentNumber = int.Parse(counter) % 10;

                if (counter.Length < 3)
                {
                    currentNumber = int.Parse(counter) % 10;
                    counter += currentNumber;
                }
                else if (counter.Length == 3 && (!counter.Contains("7") && !counter.Contains("9")))
                {
                    int nextNumber = currentNumber + 1;
                    counter = nextNumber.ToString();
                }
                else if (counter.Contains("7") || counter.Contains("9"))
                {
                    if (counter.Length == 4)
                    {
                        int nextNumber = currentNumber + 1;
                        counter = nextNumber.ToString();
                    }
                    else
                    {
                        counter += currentNumber;
                    }
                }
            }
            string output = string.Empty;

            for (int i = 0; i < charCount; i++)
            {
                int currentChar = int.Parse(Console.ReadLine());
                output += phoneKeys[currentChar];
                
            }
            Console.WriteLine(output);
        }
    }
}
