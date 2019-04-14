using System;

namespace _04._Metric_Converter
{
    class MetricConverter
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            if (from == "mm")
            {
                number /= 1000;
            }
            else if (from == "cm")
            {
                number /= 100;
            }
            if (to == "mm")
            {
                number *= 1000;
            }
            else if (to=="cm")
            {
                number *= 100;
            }

            Console.WriteLine($"{number:f3}");
        }
    }
}
