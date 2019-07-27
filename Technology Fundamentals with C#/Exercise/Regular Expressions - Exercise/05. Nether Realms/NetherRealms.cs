namespace _05._Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public class Demon
        {
            public string Name { get; set; }

            public double Damage { get; set; }

            public int Health { get; set; }
        }

        public static void Main()
        {
            string healthPattern = @"[^0-9+\-*\/.]+";
            string damagePattern = @"[+|-]?[[0-9.]+[0-9]*";
            string[] demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Demon> demonBook = new List<Demon>();

            for (int i = 0; i < demons.Length; i++)
            {
                Demon demon = new Demon();
                string currentDemon = demons[i];
                MatchCollection healthSymbols = Regex.Matches(currentDemon, healthPattern);
                demon.Name = currentDemon; ;
                demon.Health = CalculateHealth(healthSymbols);
                MatchCollection damage = Regex.Matches(currentDemon, damagePattern);
                demon.Damage = CalculateDamage(damage, currentDemon);
                demonBook.Add(demon);
            }

            foreach (var demon in demonBook.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        public static double CalculateDamage(MatchCollection damage, string currentDemon)
        {
            double pureDamage = CalculatePureDamage(damage);
            for (int j = 0; j < currentDemon.Length; j++)
            {
                if (currentDemon[j] == '*')
                {
                    pureDamage *= 2;
                }
                else if (currentDemon[j] == '/')
                {
                    pureDamage /= 2;
                }
            }

            return pureDamage;
        }


        public static double CalculatePureDamage(MatchCollection damageCollection)
        {
            double damage = 0;
            foreach (Match matchDamage in damageCollection)
            {
                damage += double.Parse(matchDamage.ToString());
            }

            return damage;
        }

        public static int CalculateHealth(MatchCollection healthCollection)
        {
            int health = 0;

            foreach (Match matchHealth in healthCollection)
            {
                foreach (var symbol in matchHealth.ToString())
                {
                    health += (int)symbol;
                }
            }

            return health;
        }
    }
}
