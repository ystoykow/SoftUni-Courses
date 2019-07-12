namespace _03._Extract_File
{
    using System;

    public class ExtractFile
    {
       public static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');
            string[] File = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {File[0]}");
            Console.WriteLine($"File extension: {File[1]}");
        }
    }
}