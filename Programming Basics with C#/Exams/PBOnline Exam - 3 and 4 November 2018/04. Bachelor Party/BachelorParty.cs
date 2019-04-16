using System;

namespace _04._Bachelor_Party
{
    class BachelorParty
    {
        static void Main()
        {
            int singer = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int guest = 0;
            int couvert = 0;
            int allGuests = 0;
            do
            {
                if (command != "The restaurant is full")
                {
                    guest = int.Parse(command);

                    if (guest < 5)
                    {
                        allGuests += guest;
                        couvert += guest * 100;
                    }
                    else if (guest >= 5)
                    {
                        allGuests += guest;
                        couvert += guest * 70;
                    }
                }
                else if (command == "The restaurant is full")
                {
                    if (couvert >= singer)
                    {
                        Console.WriteLine("You have {0} guests and {1} leva left.", allGuests, couvert - singer);
                    }
                    else if (couvert < singer)
                    {
                        Console.WriteLine("You have {0} guests and {1} leva income, but no singer.", allGuests, couvert);
                    }

                    break;
                }

                command = Console.ReadLine();

            } while (true);
        }
    }
}
