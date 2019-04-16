using System;

namespace _04._Everest
{
    class Everest
    {
        static void Main()
        {
            int days = 1;
            int start = 5364;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                else if (days == 5 && command == "Yes")
                {
                    break;
                }

                int meters = int.Parse(Console.ReadLine());

                start += meters;

                if (command == "Yes")
                {
                    days++;
                }

                if (start >= 8848)
                {
                    break;
                }
            }
            if (start >= 8848)
            {
                Console.WriteLine("Goal reached for {0} days!", days);
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine("{0}", start);
            }
        }
    }
}
