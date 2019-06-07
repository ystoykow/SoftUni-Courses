namespace _09._Greater_of_Two_Values
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());

                    int resultInt = GetMax(firstInt, secondInt);

                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    char resultChar = GetMax(firstChar, secondChar);

                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    string result = GetMax(firstString, secondString);

                    Console.WriteLine(result);
                    break;
                default:
                    break;
            }
        }
       public static int GetMax(int a , int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static char GetMax(char a, char b)
        {
            if ((int)a > (int)b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
       public static string GetMax(string a, string b)
        {
            int comparison = a.CompareTo(b);

            if (comparison>0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
