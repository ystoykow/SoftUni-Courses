namespace _04._Morse_Code_Translator
{
    using System;

    public class MorseCodeTranslator
    {
        public static void Main()
        {
            string[] code = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;
            for (int i = 0; i < code.Length; i++)
            {
                char ch = ' ';
                if (code[i] == ".-")
                {
                    ch = 'A';
                }
                else if (code[i] == "-...")
                {
                    ch = 'B';
                }
                else if (code[i] == "-.-.")
                {
                    ch = 'C';
                }
                else if (code[i] == "-..")
                {
                    ch = 'D';
                }
                else if (code[i] == ".")
                {
                    ch = 'E';
                }
                else if (code[i] == "..-.")
                {
                    ch = 'F';
                }
                else if (code[i] == "--.")
                {
                    ch = 'G';
                }
                else if (code[i] == "....")
                {
                    ch = 'H';
                }
                else if (code[i] == "..")
                {
                    ch = 'I';
                }
                else if (code[i] == ".---")
                {
                    ch = 'J';
                }
                else if (code[i] == "-.-")
                {
                    ch = 'K';
                }
                else if (code[i] == ".-..")
                {
                    ch = 'L';
                }
                else if (code[i] == "--")
                {
                    ch = 'M';
                }
                else if (code[i] == "-.")
                {
                    ch = 'N';
                }
                else if (code[i] == "---")
                {
                    ch = 'O';
                }
                else if (code[i] == ".--.")
                {
                    ch = 'P';
                }
                else if (code[i] == "--.-")
                {
                    ch = 'Q';
                }
                else if (code[i] == ".-.")
                {
                    ch = 'R';
                }
                else if (code[i] == "...")
                {
                    ch = 'S';
                }
                else if (code[i] == "-")
                {
                    ch = 'T';
                }
                else if (code[i] == "..-")
                {
                    ch = 'U';
                }
                else if (code[i] == "...-")
                {
                    ch = 'V';
                }
                else if (code[i] == ".--")
                {
                    ch = 'W';
                }
                else if (code[i] == "-..-")
                {
                    ch = 'X';
                }
                else if (code[i] == "-.--")
                {
                    ch = 'Y';
                }
                else if (code[i] == "--..")
                {
                    ch = 'Z';
                }
                else if (code[i] == "|")
                {
                    ch = ' ';
                }

                result += ch;
            }

            Console.WriteLine(result);
        }
    }
}
