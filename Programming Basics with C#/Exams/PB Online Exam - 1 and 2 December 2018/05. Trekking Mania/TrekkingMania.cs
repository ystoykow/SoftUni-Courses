using System;

namespace _05._Trekking_Mania
{
    class TrekkingMania
    {
        static void Main()
        {
            double climbers = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double totalPeople = 0;

            for (int i = 0; i < climbers; i++)
            {
                double groupMembers = double.Parse(Console.ReadLine());

                totalPeople += groupMembers;

                if (groupMembers <= 5)
                {
                    musala += groupMembers;
                }
                else if (groupMembers >= 6 && groupMembers <= 12)
                {
                    monblan += groupMembers;
                }
                else if (groupMembers >= 13 && groupMembers <= 25)
                {
                    kilimandjaro += groupMembers;
                }
                else if (groupMembers >= 26 && groupMembers <= 40)
                {
                    k2 += groupMembers;
                }
                else if (groupMembers > 40)
                {
                    everest += groupMembers;
                }
            }
            Console.WriteLine("{0:0.00}%", ((musala / totalPeople) * 100));
            Console.WriteLine("{0:0.00}%", ((monblan / totalPeople) * 100));
            Console.WriteLine("{0:0.00}%", ((kilimandjaro / totalPeople) * 100));
            Console.WriteLine("{0:0.00}%", ((k2 / totalPeople) * 100));
            Console.WriteLine("{0:0.00}%", ((everest / totalPeople) * 100));
        }
    }
}
