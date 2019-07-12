namespace _02._A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            Dictionary<string, List<int>> resources = new Dictionary<string, List<int>>();
            while (true)
            {
                string type = Console.ReadLine();
                if (type == "stop")
                {
                    break;
                }

                int value = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(type))
                {
                    resources.Add(type, new List<int>());
                }

                resources[type].Add(value);
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value.Sum()}");
            }
        }
    }
}