namespace _05._Drum_Set
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DrumSet
    {
        public static void Main()
        {
            double totalMoney = double.Parse(Console.ReadLine());
            List<int> originalDrumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            List<int> currentDrumSet = originalDrumSet.ToList();
            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    currentDrumSet[i] -= hitPower;
                    if (currentDrumSet[i] <= 0)
                    {
                        if (totalMoney >= originalDrumSet[i] * 3)
                        {
                            currentDrumSet[i] = originalDrumSet[i];
                            totalMoney -= originalDrumSet[i] * 3;
                        }
                        else
                        {
                            currentDrumSet.RemoveAt(i);
                            originalDrumSet.RemoveAt(i);
                            i--;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", currentDrumSet));
            Console.WriteLine($"Gabsy has {totalMoney:f2}lv.");
        }
    }
}
