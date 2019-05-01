namespace _02._Easter_Gifts
{
    using System;
    using System.Collections.Generic;

    public class EasterGifts
    {
        public static void Main()
        {
            string[] gifts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            while (input != "No Money")
            {
                var tokens = input.Split();
                string command = tokens[0];

                if (command == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gifts[i] == tokens[1])
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    string gift = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (index>0 && gifts.Length>index)
                    {
                        gifts[index] = gift;
                    }

                }
                else if (command=="JustInCase")
                {
                    string gift = tokens[1];

                    gifts[gifts.Length - 1] = gift;
                }

                input = Console.ReadLine();
            }

            var sortedGifts = new List<string>();

            foreach (var item in gifts)
            {
                if (item != "None")
                {
                    sortedGifts.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",sortedGifts));
        }
    }
}
