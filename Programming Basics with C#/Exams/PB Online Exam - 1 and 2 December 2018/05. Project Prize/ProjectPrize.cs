using System;

namespace _05._Project_Prize
{
    class ProjectPrize
    {
        static void Main()
        {
            int parts = int.Parse(Console.ReadLine());
            double prize = double.Parse(Console.ReadLine());

            double points = 0;

            for (int i = 1; i <= parts; i++)
            {
                double point = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    points += point * 2;
                }
                else
                {
                    points += point;
                }
            }
            Console.WriteLine("The project prize was {0:0.00} lv.", (points * prize));
        }
    }
}
