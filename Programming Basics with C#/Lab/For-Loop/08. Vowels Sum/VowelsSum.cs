﻿using System;

namespace _08._Vowels_Sum
{
    class VowelsSum
    {
        static void Main()
        {
            string word = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    sum += 1;
                }
                else if (word[i] == 'e')
                {
                    sum += 2;
                }
                else if (word[i] == 'i')
                {
                    sum += 3;
                }
                else if (word[i] == 'o')
                {
                    sum += 4;
                }
                else if (word[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
