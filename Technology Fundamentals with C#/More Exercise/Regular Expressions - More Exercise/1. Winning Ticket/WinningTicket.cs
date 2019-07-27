namespace _1._Winning_Ticket
{
    using System;

    public class WinningTicket
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                string currentTicket = tickets[i];
                if (currentTicket.Length == 20)
                {
                    string leftSide = currentTicket.Substring(0, 10);
                    string rightSide = currentTicket.Substring(10, 10);
                    int lenght = 0;
                    char symbol = ' ';
                    for (int j = 10; j >= 6; j--)
                    {
                        if (leftSide.Contains(new string('@', j)) && rightSide.Contains(new string('@', j)))
                        {
                            lenght = j;
                            symbol = '@';
                            break;
                        }
                        else if (leftSide.Contains(new string('$', j)) && rightSide.Contains(new string('$', j)))
                        {
                            lenght = j;
                            symbol = '$';
                            break;
                        }
                        else if (leftSide.Contains(new string('#', j)) && rightSide.Contains(new string('#', j)))
                        {
                            lenght = j;
                            symbol = '#';
                            break;
                        }
                        else if (leftSide.Contains(new string('^', j)) && rightSide.Contains(new string('^', j)))
                        {
                            lenght = j;
                            symbol = '^';
                            break;
                        }
                    }

                    if (lenght == 10)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {lenght}{symbol} Jackpot!");
                    }
                    else if (lenght >= 6 && lenght < 10)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {lenght}{symbol}");
                    }
                    else if (lenght <= 6)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }
            }
        }
    }
}
