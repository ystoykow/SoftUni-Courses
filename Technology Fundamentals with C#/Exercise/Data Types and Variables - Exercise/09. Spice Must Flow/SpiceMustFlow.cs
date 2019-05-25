namespace _09._Spice_Must_Flow
{
    using System;

    class SpiceMustFlow
    {
        static void Main()
        {
            int source = int.Parse(Console.ReadLine());
            int totalSpices = 0;
            int days = 0;

            while (source >= 100)
            {
                totalSpices += source;

                days++;
                source -= 10;
                totalSpices -= 26;
            }

            if (totalSpices!=0)
            {
                totalSpices -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSpices);
        }
    }
}
