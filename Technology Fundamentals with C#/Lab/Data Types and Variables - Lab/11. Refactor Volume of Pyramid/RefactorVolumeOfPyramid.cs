namespace _11._Refactor_Volume_of_Pyramid
{
    using System;

    class RefactorVolumeOfPyramid
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());
            double result  = length*width*heigth / 3;
            Console.Write($"Pyramid Volume: {result:f2}");

        }
    }
}
