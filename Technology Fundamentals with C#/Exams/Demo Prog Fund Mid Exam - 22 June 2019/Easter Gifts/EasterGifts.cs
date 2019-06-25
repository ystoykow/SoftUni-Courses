namespace Easter_Gifts
{
    using System;

    public class EasterGifts
    {
        public static void Main()
        {
            string[] gifts = Console.ReadLine().Split();
            string input = Console.ReadLine();
            while (input != "No Money")
            {
                string[] tokens = input.Split();
                string gift = tokens[1];

                if (tokens[0] == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gifts[i] == gift)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (tokens[0]=="Required")
                {
                    int index = int.Parse(tokens[2]);
                    if (index >= 0 && index < gifts.Length)
                    {
                        gifts[index] = gift;
                    }
                }
                else if (tokens[0] == "JustInCase")
                {
                    gifts[gifts.Length - 1] = gift;
                }
                input = Console.ReadLine();
            }

            foreach (var gift in gifts)
            {
                if (gift != "None")
                {
                    Console.Write($"{gift} ");
                }
            }
        }
    }
}
