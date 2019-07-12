namespace _05._Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            int dragonCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            var avgStats = new Dictionary<string, double[]>();
            for (int i = 0; i < dragonCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];
                int dmg = 45;
                int hp = 250;
                int armor = 10;
                if (input[2] != "null")
                {
                    dmg = int.Parse(input[2]);
                }

                if (input[3] != "null")
                {
                    hp = int.Parse(input[3]);
                }

                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<int>>());
                    dragons[type].Add(name, new List<int>());
                    dragons[type][name].Add(dmg);
                    dragons[type][name].Add(hp);
                    dragons[type][name].Add(armor);
                    avgStats[type] = new double[] { 0.0, 0.0, 0.0 };
                }
                else if (dragons.ContainsKey(type) && !dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new List<int>());
                    dragons[type][name].Add(dmg);
                    dragons[type][name].Add(hp);
                    dragons[type][name].Add(armor);
                }
                else if (dragons.ContainsKey(type) && dragons[type].ContainsKey(name))
                {
                    dragons[type][name].RemoveRange(0, 3);
                    dragons[type][name].Add(dmg);
                    dragons[type][name].Add(hp);
                    dragons[type][name].Add(armor);
                }
            }

            foreach (var type in dragons)
            {
                double dmg = 0.0;
                double hp = 0.0;
                double armor = 0.0;
                foreach (var item in type.Value)
                {
                    dmg += item.Value[0];
                    hp += item.Value[1];
                    armor += item.Value[2];
                }

                avgStats[type.Key][0] = dmg / type.Value.Count;
                avgStats[type.Key][1] = hp / type.Value.Count;
                avgStats[type.Key][2] = armor / type.Value.Count;
            }

            foreach (var dragon in dragons)
            {
                Console.WriteLine($"{dragon.Key}::({avgStats[dragon.Key][0]:f2}/{avgStats[dragon.Key][1]:f2}/{avgStats[dragon.Key][2]:f2})");
                foreach (var kvp in dragon.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{kvp.Key} -> damage: {kvp.Value[0]}, health: {kvp.Value[1]}, armor: {kvp.Value[2]}");
                }
            }
        }
    }
}
