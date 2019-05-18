namespace _09._Padawan_Equipment
{
    using System;

    class PadawanEquipment
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double sabersTotal = Math.Ceiling(studentsCount * 1.1);
            int beltDiscount = studentsCount / 6;
            int beltsTotal = studentsCount - beltDiscount;

            double totalSabersPrice = sabersTotal * saberPrice;
            double totalBeltsPrice = beltsTotal * beltPrice;
            double totalRobesPrice = robePrice * studentsCount;

            double totalPrice = totalBeltsPrice + totalRobesPrice + totalSabersPrice;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-money:f2}lv more.");
            }
        }
    }
}
