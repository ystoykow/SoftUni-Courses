namespace _01._Extract_Person_Info
{
    using System;

   public class ExtractPersonInfo
    {
        public static void Main()
        {
            int countText = int.Parse(Console.ReadLine());

            for (int i = 0; i < countText; i++)
            {
                string text = Console.ReadLine();
                int startNameIndex = text.IndexOf('@');
                int endNameIndex = text.IndexOf('|');
                int startAgeIndex = text.IndexOf('#');
                int endAgeIndex = text.IndexOf('*');
                int nameLength = endNameIndex - startNameIndex - 1;
                int ageLength = endAgeIndex - startAgeIndex - 1;
                string name = text.Substring(startNameIndex + 1, nameLength);
                string age = text.Substring(startAgeIndex + 1, ageLength);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}