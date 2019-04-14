using System;
namespace _09.Birthday
{
    class Birthday
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double higth = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double aquaCap = length * width * higth;
            double aquaLiters = aquaCap * 0.001;
            double realPerc = percent * 0.01;
            double totalLiters = aquaLiters * (1 - realPerc);
            Console.WriteLine("{0:0.000}", totalLiters);

        }
    }
}
