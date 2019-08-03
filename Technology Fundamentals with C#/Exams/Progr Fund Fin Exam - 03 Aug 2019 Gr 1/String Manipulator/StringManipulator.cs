namespace String_Manipulator
{
    using System;

    public class StringManipulator
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "End")
            {
                if (commands[0] == "Translate")
                {
                    char oldChar = char.Parse(commands[1]);
                    char newChar = char.Parse(commands[2]);
                    input = input.Replace(oldChar, newChar);
                    Console.WriteLine(input);
                }
                else if (commands[0] == "Includes")
                {
                    string text = commands[1];
                    bool haveIt = input.Contains(text);
                    Console.WriteLine(haveIt);
                }
                else if (commands[0] == "Start")
                {
                    string text = commands[1];
                    bool startWith = input.StartsWith(text);
                    Console.WriteLine(startWith);
                }
                else if (commands[0] == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (commands[0] == "FindIndex")
                {
                    char charToFind = char.Parse(commands[1]);
                    int indexOfLast = input.LastIndexOf(charToFind);
                    Console.WriteLine(indexOfLast);
                }
                else if (commands[0] == "Remove")
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}
