namespace _03._Treasure_Finder
{
    using System;
    using System.Linq;
    using System.Text;

    public class TreasureFinder
    {
        public static void Main()
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "find")
            {
                StringBuilder result = new StringBuilder();
                int j = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int newCharValue = input[i];
                    newCharValue -= keys[j];
                    result.Append((char) newCharValue);
                    j++;
                    if (j >= keys.Length)
                    {
                        j = 0;
                    }
                }

                string finalResult = result.ToString();
                int startIndexOfType = finalResult.IndexOf('&');
                int endIndexOfType = finalResult.IndexOf('&', startIndexOfType + 1);
                int startIndexOfCoords = finalResult.IndexOf('<');
                int endIndexOfCoords = finalResult.IndexOf('>');
                string type = finalResult.Substring(startIndexOfType + 1, endIndexOfType - startIndexOfType - 1);
                string coords = finalResult.Substring(startIndexOfCoords + 1, endIndexOfCoords - startIndexOfCoords - 1);
                Console.WriteLine($"Found {type} at {coords}");
                input = Console.ReadLine();
            }
        }
    }
}