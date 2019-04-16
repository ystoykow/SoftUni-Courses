using System;

namespace _03._Computer_Room
{
    class ComputerRoom
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string dayType = Console.ReadLine();

            double price = 0;

            if (dayType.Equals("day"))
            {
                switch (month)
                {
                    case "january":
                        price = +10.50;
                        break;
                    case "february":
                        price = +10.50;
                        break;
                    case "march":
                        price = +10.50;
                        break;
                    case "april":
                        price = +10.50;
                        break;
                    case "may":
                        price = +10.50;
                        break;
                    case "june":
                        price = +12.60;
                        break;
                    case "july":
                        price = +12.60;
                        break;
                    case "august":
                        price = +12.60;
                        break;
                    case "september":
                        price = +12.60;
                        break;
                    case "october":
                        price = +12.60;
                        break;
                    case "november":
                        price = +12.60;
                        break;
                    case "december":
                        price = +12.60;
                        break;
                    default:
                        break;
                }
            }
            else if (dayType.Equals("night"))
            {
                switch (month)
                {
                    case "january":
                        price = +8.40;
                        break;
                    case "february":
                        price = +8.40;
                        break;
                    case "march":
                        price = +8.40;
                        break;
                    case "april":
                        price = +8.40;
                        break;
                    case "may":
                        price = +8.40;
                        break;
                    case "june":
                        price = +10.20;
                        break;
                    case "july":
                        price = +10.20;
                        break;
                    case "august":
                        price = +10.20;
                        break;
                    case "september":
                        price = +10.20;
                        break;
                    case "october":
                        price = +10.20;
                        break;
                    case "november":
                        price = +10.20;
                        break;
                    case "december":
                        price = +10.20;
                        break;
                    default:
                        break;
                }
            }

            if (people >= 4)
            {
                double priceperson = price - (price * 0.1);
                double allprice = (priceperson * hours) * people;

                if (hours >= 5)
                {
                    double pricetotaldiscount = priceperson - (priceperson * 0.5);
                    double allpricetotaldiscount = (pricetotaldiscount * hours) * people;

                    Console.WriteLine($"Price per person for one hour: {pricetotaldiscount:F2}");
                    Console.WriteLine($"Total cost of the visit: {allpricetotaldiscount:F2}");
                }
                else
                {
                    Console.WriteLine($"Price per person for one hour: {priceperson:F2}");
                    Console.WriteLine($"Total cost of the visit: {allprice:F2}");
                }
            }
            else
            {
                double pplhoursprice = price * hours * people;
                Console.WriteLine($"Price per person for one hour: {price:F2}");
                Console.WriteLine($"Total cost of the visit: {pplhoursprice:F2}");
            }
        }
    }
}
