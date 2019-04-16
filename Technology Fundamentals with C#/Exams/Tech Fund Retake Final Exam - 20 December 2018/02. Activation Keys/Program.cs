using System;
using System.Collections.Generic;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine().Split('&');

            List<string> validKeys = new List<string>();
            for (int i = 0; i < keys.Length; i++)
            {
                bool isValidKey = false;
                string key = keys[i];
                string validKey = string.Empty;

                if (key.Length == 16 || key.Length == 25)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (char.IsLetterOrDigit(key[j]))
                        {
                            validKey += key[j];
                            isValidKey = true;
                        }
                        else
                        {
                            isValidKey = false;
                            break;
                        }
                    }

                }
                if (isValidKey)
                {
                    validKeys.Add(validKey);
                }
            }
            List<string> separatedValidKeys = new List<string>();
            for (int i = 0; i < validKeys.Count; i++)
            {
                if (validKeys[i].Length == 16)
                {

                    string a = validKeys[i].Substring(0, 4);
                    string b = validKeys[i].Substring(4, 4);
                    string c = validKeys[i].Substring(8, 4);
                    string d = validKeys[i].Substring(12, 4);
                    string result = a + '-' + b + '-' + c + '-' + d;

                    separatedValidKeys.Add(result);
                }
                else
                {
                    string a = validKeys[i].Substring(0, 5);
                    string b = validKeys[i].Substring(5, 5);
                    string c = validKeys[i].Substring(10, 5);
                    string d = validKeys[i].Substring(15, 5);
                    string e = validKeys[i].Substring(20, 5);
                    string result = a + '-' + b + '-' + c + '-' + d + '-' + e;

                    separatedValidKeys.Add(result);
                }
            }
            List<string> finalResult = new List<string>();
            for (int i = 0; i < separatedValidKeys.Count; i++)
            {
                string key = separatedValidKeys[i];
                string finalKey = string.Empty;
                for (int j = 0; j < key.Length; j++)
                {
                    if (char.IsDigit(key[j]))
                    {
                        int old = (int)char.GetNumericValue(key[j]);
                        int newChar = 9 - old;
                        finalKey += newChar;
                    }
                    else
                    {
                        char addChar = char.ToUpper(key[j]);
                        finalKey += addChar;
                    }
                }
                finalResult.Add(finalKey);

            }
            Console.WriteLine(string.Join(", ",finalResult));
        }
    }
}
