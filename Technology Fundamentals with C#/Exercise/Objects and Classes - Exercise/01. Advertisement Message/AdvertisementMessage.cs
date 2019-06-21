namespace _01._Advertisement_Message
{
    using System;

   public class AdvertisementMessage
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var rnd = new Random();
            string[] phrases = {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] respects =
            {
                " Now I feel good.",
                " I have succeeded with this product.",
                " Makes miracles. I am happy of the results!",
                " I cannot believe but now I feel awesome.",
                " Try it yourself, I am very satisfied.",
                " I feel great!"
            };

            string[] authors =
            {
                " Diana ", " Petya ", " Stella ", " Elena ", " Katya ", " Iva ", " Annie ", " Eva"
            };

            string[] towns =
            {
                " Burgas ", " Sofia ", " Plovdiv ", " Varna ", " Ruse"
            };

            for (int i = 0; i < count; i++)
            {
                string phrase = phrases[rnd.Next(0, phrases.Length)];
                string respect = respects[rnd.Next(0, respects.Length)];
                string author = authors[rnd.Next(0, authors.Length)];
                string town = towns[rnd.Next(0, towns.Length)];
                Console.WriteLine($"{phrase}{respect}{author} - {town}");
            }
        }
    }
}
