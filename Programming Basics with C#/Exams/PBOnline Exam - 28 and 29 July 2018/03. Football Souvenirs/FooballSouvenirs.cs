    using System;

    namespace _03._Football_Souvenirs
    {
        class FooballSouvenirs
        {
            static void Main()
            {
                string team = Console.ReadLine();
                string souvenir = Console.ReadLine();
                int count = int.Parse(Console.ReadLine());

                double price = 0;
                bool isProductFalse = false;
                bool isCountryFalse = false;

                if (souvenir!="flags" && souvenir != "caps" && souvenir != "posters" && souvenir != "stickers")
                {
                    isProductFalse = true;
                    Console.WriteLine("Invalid stock!");
                }

                if (team.Equals("Argentina"))
                {

                    if (souvenir.Equals("flags"))
                    {
                        price += 3.25;
                    }
                    else if (souvenir.Equals("caps"))
                    {
                        price += 7.20;
                    }
                    else if (souvenir.Equals("posters"))
                    {
                        price += 5.10;
                    }
                    else if (souvenir.Equals("stickers"))
                    {
                        price += 1.25;
                    }
                }
                else if (team.Equals("Brazil"))
                {

                    if (souvenir.Equals("flags"))
                    {
                        price += 4.20;
                    }
                    else if (souvenir.Equals("caps"))
                    {
                        price += 8.50;
                    }
                    else if (souvenir.Equals("posters"))
                    {
                        price += 5.35;
                    }
                    else if (souvenir.Equals("stickers"))
                    {
                        price += 1.20;
                    }
                }
                else if (team.Equals("Croatia"))
                {

                    if (souvenir.Equals("flags"))
                    {
                        price += 2.75;
                    }
                    else if (souvenir.Equals("caps"))
                    {
                        price += 6.90;
                    }
                    else if (souvenir.Equals("posters"))
                    {
                        price += 4.95;
                    }
                    else if (souvenir.Equals("stickers"))
                    {
                        price += 1.10;
                    }
                }
                else if (team.Equals("Denmark"))
                {

                    if (souvenir.Equals("flags"))
                    {
                        price += 3.10;
                    }
                    else if (souvenir.Equals("caps"))
                    {
                        price += 6.50;
                    }
                    else if (souvenir.Equals("posters"))
                    {
                        price += 4.80;
                    }
                    else if (souvenir.Equals("stickers"))
                    {
                        price += 0.90;
                    }
                }
                else
                {
                    isCountryFalse = true;
                    Console.WriteLine("Invalid country!");
                }

                if (isProductFalse == false && isCountryFalse == false)
                {
                    Console.WriteLine("Pepi bought {0} {1} of {2} for {3:0.00} lv.", count, souvenir, team, count * price);
                }
            }
        }
    }
