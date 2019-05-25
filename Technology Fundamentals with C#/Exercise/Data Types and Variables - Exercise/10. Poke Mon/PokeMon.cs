namespace _10._Poke_Mon
{
    using System;

    class PokeMon
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int originalPokePower = pokePower;
            int pokedCount = 0;
            bool isPossible = false;

            if (pokePower % 2 == 0)
            {
                isPossible = true;
            }

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokedCount++;

                if (isPossible && originalPokePower / 2 == pokePower)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedCount);
        }
    }
}
