namespace _07._String_Explosion
{
    using System;

    public class StringExplosion
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int explosionPower = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    if (text[i + 1] != 1)
                    {
                        explosionPower += (int)char.GetNumericValue(text[i + 1]) - 1;
                    }

                    text = text.Remove(i + 1, 1);
                }
                else if (text[i] != '>' && explosionPower > 0)
                {
                    text = text.Remove(i, 1);
                    explosionPower--;
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}