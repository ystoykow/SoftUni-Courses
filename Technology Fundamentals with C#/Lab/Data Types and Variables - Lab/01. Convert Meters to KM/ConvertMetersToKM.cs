namespace _01._Convert_Meters_to_KM
{
    using System;

    class ConvertMetersToKM
    {
        static void Main()
        {
            double inputInCm = int.Parse(Console.ReadLine());
            double outputInKm = inputInCm / 1000;
            Console.WriteLine($"{outputInKm:f2}");

        }
    }
}
