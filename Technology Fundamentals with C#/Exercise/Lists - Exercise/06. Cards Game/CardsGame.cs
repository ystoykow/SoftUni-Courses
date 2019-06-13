namespace _06._Cards_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CardsGame
    {
        public static void Main()
        { 

            List<int> playerOneCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (playerOneCards[0] > playerTwoCards[0])
                {
                    playerOneCards.Add(playerOneCards[0]);
                    playerOneCards.Add(playerTwoCards[0]);
                    playerOneCards.RemoveAt(0);
                    playerTwoCards.RemoveAt(0);
                }
                else if (playerOneCards[0] < playerTwoCards[0])
                {
                    playerTwoCards.Add(playerTwoCards[0]);
                    playerTwoCards.Add(playerOneCards[0]);
                    playerOneCards.RemoveAt(0);
                    playerTwoCards.RemoveAt(0);
                }
                else
                {
                    playerOneCards.RemoveAt(0);
                    playerTwoCards.RemoveAt(0);
                }
                if (playerOneCards.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {playerTwoCards.Sum()}");
                    break;
                }
                else if (playerTwoCards.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {playerOneCards.Sum()}");
                    break;
                }
            }
        }
    }
}
