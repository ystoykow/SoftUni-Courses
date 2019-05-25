namespace _03._Elevator
{
    using System;

    class Elevator
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            if (peopleCount % elevatorCapacity == 0)
            {
                Console.WriteLine(peopleCount/elevatorCapacity);
            }
            else
            {
                Console.WriteLine((peopleCount/elevatorCapacity)+1);
            }
        }
    }
}
