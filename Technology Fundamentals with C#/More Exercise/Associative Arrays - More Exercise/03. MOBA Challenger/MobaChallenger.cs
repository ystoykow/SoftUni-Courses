namespace _03._MOBA_Challenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MobaChallenger
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> playerDB = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] tokens = input.Split("->");
                    string player = tokens[0].Trim();
                    string position = tokens[1].Trim();
                    int skillPoints = int.Parse(tokens[2].Trim());
                    if (!playerDB.ContainsKey(player))
                    {
                        playerDB.Add(player, new Dictionary<string, int>());
                        playerDB[player].Add(position, skillPoints);
                    }
                    else if (playerDB.ContainsKey(player) && !playerDB[player].ContainsKey(position))
                    {
                        playerDB[player].Add(position, skillPoints);
                    }
                    else if (playerDB.ContainsKey(player) && playerDB[player][position] < skillPoints)
                    {
                        playerDB[player][position] = skillPoints;
                    }
                }
                else
                {
                    string[] tokens = input.Split(" ");
                    string playerOne = tokens[0].Trim();
                    string playerTwo = tokens[2].Trim();
                    bool haveMatch = false;
                    if (playerDB.ContainsKey(playerOne) && playerDB.ContainsKey(playerTwo))
                    {
                        MakeDuel(playerOne, playerTwo, playerDB);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in playerDB.OrderByDescending(x => x.Value.Sum(y => y.Value)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Sum(x => x.Value)} skill");
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }

        public static void MakeDuel(string playerOne, string playerTwo, Dictionary<string, Dictionary<string, int>> playerDb)
        {
            foreach (var positionPlayerOne in playerDb[playerOne])
            {
                foreach (var positionPlayerTwo in playerDb[playerTwo])
                {
                    if (positionPlayerTwo.Key == positionPlayerOne.Key)
                    {
                        int playerOneSkills = playerDb[playerOne].Sum(x => x.Value);
                        int playerTwoSkills = playerDb[playerTwo].Sum(x => x.Value);
                        if (playerOneSkills > playerTwoSkills)
                        {
                            playerDb.Remove(playerTwo);
                            return;

                        }
                        else if (playerTwoSkills > playerOneSkills)
                        {
                            playerDb.Remove(playerOne);
                            return;
                        }
                    }
                }
            }
        }
    }
}
