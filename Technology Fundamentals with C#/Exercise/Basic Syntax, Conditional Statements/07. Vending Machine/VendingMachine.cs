namespace _07._Vending_Machine
{
    using System;

    class VendingMachine
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double sum = 0;

            while(input!="Start")
            {
                double coins = double.Parse(input);

                if (coins == 2 || coins == 1 || coins == 0.5 || coins == 0.2 || coins == 0.1)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while(input!="End")
            {
                if(input=="Nuts")
                {
                    if(sum>=2)
                    {
                        Console.WriteLine($"Purchased nuts");
                        sum -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (sum >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        sum -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        sum -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        sum -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (sum >= 1)
                    {
                        Console.WriteLine($"Purchased coke");
                        sum -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
