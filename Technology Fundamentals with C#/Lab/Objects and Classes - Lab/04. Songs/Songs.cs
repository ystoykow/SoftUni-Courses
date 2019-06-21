
namespace _04._Songs
{
    using System;
    using System.Collections.Generic;

    public class Songs
    {
        public class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }

        }

        public static void Main()
        {
            int songsCount = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                Song song = new Song
                {
                    TypeList = input[0],
                    Name = input[1],
                    Time = input[2]
                };
                
                songs.Add(song);
            }

            string typeOfSongs = Console.ReadLine();
            foreach (var song in songs)
            {
                if (typeOfSongs == "all")
                {
                    Console.WriteLine(song.Name);
                }
                else
                {
                    if (typeOfSongs == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
