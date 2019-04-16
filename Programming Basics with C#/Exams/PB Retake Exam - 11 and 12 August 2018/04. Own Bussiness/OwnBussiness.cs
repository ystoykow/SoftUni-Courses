using System;

namespace _04._Own_Bussiness
{
    class OwnBussiness
    {
        static void Main()
        {
            int weigth = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int higth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int space = weigth * length * higth;
            int comps = 0;
            int morespace = 0;
            int compspace = 0;

            do
            {
                if (command == "Done")
                {
                    Console.WriteLine("{0} Cubic meters left.", morespace);

                    break;
                }
                else if (space >= compspace && command != "Done")
                {
                    comps = int.Parse(command);

                    compspace += 1 * 1 * 1 * comps;
                    morespace = space - compspace;
                }
                else if (space < compspace)
                {
                    int nospace = compspace - space;

                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", nospace);

                    break;
                }

                command = Console.ReadLine();

            } while (true);
        }
    }
}
