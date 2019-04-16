using System;
using System.Linq;

namespace _03._Cooking_Factory
{
    public class Batch
    {
        public int Quality { get; set; }
        public double AvgSum { get; set; }
        public int Lenght { get; set; }
        public int[] Batches { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Batch bestBatch = new Batch
            {
                Quality = int.MinValue,
                AvgSum = double.MinValue,
                Lenght = int.MaxValue,

            };
            while(command!="Bake It!")
            {
                int[] batch = command.Split('#').Select(int.Parse).ToArray();
                string ids = String.Join(" ", batch.Select(p => p.ToString()).ToArray());
                var currentBatch = new Batch
                {
                    Quality = batch.Sum(),
                    AvgSum = batch.Average(),
                    Lenght = batch.Length,
                    Batches = batch
                    
                };
                if(currentBatch.Quality>bestBatch.Quality)
                {
                    bestBatch = currentBatch;

                }
                else if (currentBatch.Quality==bestBatch.Quality)
                {
                    if (currentBatch.AvgSum>bestBatch.AvgSum)
                    {
                        bestBatch = currentBatch;
                    }
                    else if (currentBatch.AvgSum==bestBatch.AvgSum)
                    {
                        if (currentBatch.Lenght < bestBatch.Lenght)
                        {
                            bestBatch = currentBatch;
                        }
                    }
                }
                
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {bestBatch.Quality}");
            Console.WriteLine(string.Join(" ", bestBatch.Batches));
        }
    }
}
