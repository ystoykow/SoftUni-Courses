﻿using System;

namespace _02._Bonus_Score
{
    class BonusScore
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (number <= 100)
            {
                bonusPoints += 5;
            }
            else if (number>1000)
            {
                bonusPoints =number* 0.1;
            }
            else if (number>100)
            {
                bonusPoints =number * 0.2;
            }
            if (number %2==0)
            {
                bonusPoints += 1;
            }
            if (number %10 ==5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(number+bonusPoints);
        }
    }
}
