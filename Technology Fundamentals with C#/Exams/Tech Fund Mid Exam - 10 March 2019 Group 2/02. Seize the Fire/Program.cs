using System;
using System.Collections.Generic;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> outOfFire = new List<int>();
            List<int> validFires = new List<int>();
            string[] input = Console.ReadLine().Split('#');
            int water = int.Parse(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                string[] current = input[i].Split('=');
                string fireLevel = current[0].Trim();
                int fireValue = int.Parse(current[1].Trim());
                if (fireLevel == "High")
                {
                    if (fireValue >= 81 && fireValue <= 125)
                    {
                        validFires.Add(fireValue);
                    }
                }
                else if (fireLevel == "Medium")
                {
                    if (fireValue >= 51 && fireValue <= 80)
                    {
                        validFires.Add(fireValue);
                    }
                }
                else if (fireLevel == "Low")
                {
                    if (fireValue >= 1 && fireValue <= 50)
                    {
                        validFires.Add(fireValue);
                    }
                }
            }
            int totalFire = 0;
            double effort = 0;
            bool haveWater = true;
            while(water>0 && validFires.Count>0)
            {
                int count = 0;
                for (int i = 0; i < validFires.Count; i++)
                {
                    if (water >= validFires[i])
                    {
                        water -= validFires[i];
                        totalFire += validFires[i];
                        effort += validFires[i] * 0.25;
                        outOfFire.Add(validFires[i]);
                        validFires.Remove(validFires[i]);
                        i = -1;

                    }
                    else
                    {
                        count++;
                    }
                    if(count==validFires.Count)
                    {
                        haveWater = false;
                    }

                }
                if(!haveWater)
                {
                    break;
                }
            }
            Console.WriteLine("Cells:");
            foreach (var item in outOfFire)
            {
                Console.WriteLine($" - {item}");

            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
