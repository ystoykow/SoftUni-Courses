using System;

namespace _05._Wedding_Presents
{
    class WeddingPresents
    {
        static void Main()
        {
            double guests = double.Parse(Console.ReadLine());
            double presentsCount = double.Parse(Console.ReadLine());

            double A = 0;
            double B = 0;
            double V = 0;
            double G = 0;

            for (int i = 0; i < presentsCount; i++)
            {
                string pressents = Console.ReadLine();

                if (pressents == "A")
                {
                    A += 1;
                }
                else if (pressents == "B")
                {
                    B += 1;
                }
                else if (pressents == "V")
                {
                    V += 1;
                }
                else if (pressents == "G")
                {
                    G += 1;
                }
            }

            Console.WriteLine("{0:0.00}%", (A / presentsCount) * 100);
            Console.WriteLine("{0:0.00}%", (B / presentsCount) * 100);
            Console.WriteLine("{0:0.00}%", (V / presentsCount) * 100);
            Console.WriteLine("{0:0.00}%", (G / presentsCount) * 100);
            Console.WriteLine("{0:0.00}%", (presentsCount / guests) * 100);
        }
    }
}
