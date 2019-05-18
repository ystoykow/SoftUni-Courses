namespace _01._Ages
{
    using System;

    class Ages
    {
        static void Main()
        {
            int years = int.Parse(Console.ReadLine());

            if (years >= 0 && years <= 2)
            {
                Console.WriteLine("baby");
            }
            else if(years >2 && years <=13)
            {
                Console.WriteLine("child");
            }
            else if (years > 13 && years <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (years > 19 && years <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
