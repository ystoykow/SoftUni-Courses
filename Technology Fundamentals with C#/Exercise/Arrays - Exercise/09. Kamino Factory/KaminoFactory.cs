namespace _09._Kamino_Factory
{
    using System;
    using System.Linq;

    public class KaminoFactory
    {
        public static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] bestSequance = new int[lenght];
            int bestStartIndex = lenght;
            int bestSample = 1;
            int bestSum = 0;
            int bestLenght = -1;
            int sampleCount = 1;
            int startIndex = lenght;

            while (input != "Clone them!")
            {
                int[] sequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sum = sequence.Sum();
                int count = 1;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (bestLenght < count)
                    {
                        bestLenght = count;
                        bestStartIndex = i - bestLenght;
                        bestSum = sum;
                        bestSample = sampleCount;
                        bestSequance = sequence;
                    }
                    else if (bestLenght == count)
                    {
                        startIndex = i - bestLenght;

                        if (startIndex < bestStartIndex)
                        {
                            bestStartIndex = startIndex;
                            bestSum = sum;
                            bestSample = sampleCount;
                            bestSequance = sequence;
                        }
                        else if (startIndex == bestStartIndex)
                        {
                            if (bestSum < sum)
                            {
                                bestSum = sum;
                                bestSample = sampleCount;
                                bestSequance = sequence;
                            }
                        }
                    }
                }

                sampleCount++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ",bestSequance));
        }
    }
}
