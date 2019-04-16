using System;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "end")
            {
                bool isValidArtist = false;
                bool isValidSong = false;
                string[] tokens = command.Split(":");
                string artist = tokens[0];
                string song = tokens[1];
                for (int i = 1; i < artist.Length; i++)
                {
                    if (char.IsUpper(artist[0]))
                    {
                        if (char.IsLower(artist[i]) || artist[i] == ' ' || artist[i] == '\'')
                        {
                            isValidArtist = true;
                        }
                        else
                        {
                            isValidArtist = false;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < song.Length; i++)
                {
                    if (char.IsUpper(song[i]) || song[i] == ' ')
                    {
                        isValidSong = true;
                    }
                    else
                    {
                        isValidSong = false;
                        break;
                    }
                }
                if (isValidSong && isValidArtist)
                {
                    int encyptNum = artist.Length;
                    string resultArtist = string.Empty;
                    string resultSong = string.Empty;

                    for (int i = 0; i < artist.Length; i++)
                    {
                        if (char.IsUpper(artist[i]))
                        {
                            if (artist[i] + encyptNum > 90)
                            {
                                int additional = (artist[i] + encyptNum) - 90;
                                int newChar = additional + 64;
                                resultArtist += (char)newChar;
                            }
                            else
                            {
                                int newChar = artist[i] + encyptNum;
                                resultArtist += (char)newChar;
                            }
                        }
                        else if (char.IsWhiteSpace(artist[i]))
                        {
                            resultArtist += ' ';
                        }
                        else if (char.IsLower(artist[i]))
                        {
                            if (artist[i]+encyptNum>122)
                            {
                                int additional = (artist[i] + encyptNum) - 122;
                                int newChar = additional + 96;
                                resultArtist += (char)newChar;
                            }
                            else
                            {
                                int newChar = artist[i] + encyptNum;
                                resultArtist += (char)newChar;
                            }
                        }
                        else
                        {
                            resultArtist += artist[i];
                        }
                    }
                    for (int i = 0; i < song.Length; i++)
                    {
                        if (char.IsLetter(song[i]))
                        {
                            if (song[i] + encyptNum > 90)
                            {
                                int additional = (song[i] + encyptNum) - 90;
                                int newChar = additional + 64;
                                resultSong += (char)newChar;
                            }
                            else
                            {
                                int newChar = song[i] + encyptNum;
                                resultSong += (char)newChar;
                            }
                        }
                        else if (char.IsWhiteSpace(song[i]))
                        {
                            resultSong += ' ';
                        }
                        else
                        {
                            resultSong += song[i];
                        }
                        
                    }
                    Console.WriteLine($"Successful encryption: {resultArtist}@{resultSong}");
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
                command = Console.ReadLine();
            }
        }
    }
}
