using System;

namespace _02._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 100;
            int playerCoins = 0;
            int countRooms = 0;
            string[] rooms = Console.ReadLine().Split('|');
            for (int i = 0; i < rooms.Length; i++)
            {
                countRooms++;
                string[] room = rooms[i].Split(' ' ,StringSplitOptions.RemoveEmptyEntries);
                string obj = room[0];
                int num = int.Parse(room[1]);
                if (obj == "potion")
                {
                    if (playerHP + num > 100)
                    {
                        Console.WriteLine($"You healed for {100 - playerHP} hp.");
                        playerHP = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {num} hp.");
                        playerHP += num;
                    }
                    Console.WriteLine($"Current health: {playerHP} hp.");
                }
                else if (obj == "chest")
                {
                    Console.WriteLine($"You found {num} coins.");
                    playerCoins += num;
                }
                else
                {
                    if (playerHP - num <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {obj}.");
                        Console.WriteLine($"Best room: {countRooms}");
                        return;
                    }
                    else
                    {
                        playerHP -= num;
                        Console.WriteLine($"You slayed {obj}.");
                    }
                }
            }
            if (countRooms==rooms.Length)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Coins: {playerCoins}");
                Console.WriteLine($"Health: {playerHP}");
            }
        }
    }
}
