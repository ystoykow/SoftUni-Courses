namespace _06._Triples_of_Latin_Letter
{
    using System;

    class TriplesOfLatinLetters
    {
        static void Main()
        {
            int charsTo = int.Parse(Console.ReadLine());

            for (int i = 0; i < charsTo; i++)
            {
                for (int j = 0; j < charsTo; j++)
                {
                    for (int k = 0; k < charsTo; k++)
                    {
                        char firstChar = (char)(i + 97);
                        char secondChar = (char)(j + 97);
                        char thirdChar = (char)(k + 97);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
