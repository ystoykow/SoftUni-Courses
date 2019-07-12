namespace _03._Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var junk = new Dictionary<string, int>();
            var keyMats = new Dictionary<string, int>();
            keyMats.Add("shards", 0);
            keyMats.Add("fragments", 0);
            keyMats.Add("motes", 0);
            bool obtained = false;
            while (!obtained)
            {
                string[] loot = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < loot.Length; i++)
                {
                    int countMats = int.Parse(loot[i]);
                    string typeOfMats = loot[i + 1];
                    i++;
                    if (typeOfMats == "shards" || typeOfMats == "fragments" || typeOfMats == "motes")
                    {
                        keyMats[typeOfMats] += countMats;
                    }
                    else
                    {
                        if (!junk.ContainsKey(typeOfMats))
                        {
                            junk.Add(typeOfMats, 0);
                        }

                        junk[typeOfMats] += countMats;
                    }

                    if (keyMats["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        keyMats["shards"] -= 250;
                        obtained = true;
                    }
                    else if (keyMats["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        keyMats["fragments"] -= 250;
                        obtained = true;
                    }
                    else if (keyMats["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        keyMats["motes"] -= 250;
                        obtained = true;
                    }

                    if (obtained)
                    {
                        break;
                    }
                }
            }

            foreach (var kvp in keyMats.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
