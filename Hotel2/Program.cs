using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());
            double totalPriceStudio = 0.00;
            double totalPriceDouble = 0.00;
            double totalPriceSuite = 0.00;
            

            switch (month)
            {
                case "May":
                case "October":
                    totalPriceStudio = nightsCount*50;
                    totalPriceDouble = nightsCount*65;
                    totalPriceSuite = nightsCount*75;
                    if (nightsCount > 7) totalPriceStudio = nightsCount * 50 * 0.95;
                    if (nightsCount > 7 && month == "October") totalPriceStudio = (nightsCount - 1)* 50 * 0.95;
                    break;
                case "June":
                case "September":
                    totalPriceStudio = nightsCount * 60;
                    totalPriceDouble = nightsCount * 72;
                    totalPriceSuite = nightsCount * 82;
                    if (nightsCount > 14) totalPriceDouble = nightsCount * 72 * 0.9;
                    if (nightsCount > 7 && month == "September") totalPriceStudio = (nightsCount - 1) * 60;
                    break;
                case "July":
                case "August":
                case "December":
                    totalPriceStudio = nightsCount * 68;
                    totalPriceDouble = nightsCount * 77;
                    totalPriceSuite = nightsCount * 89;
                    if (nightsCount > 14) totalPriceSuite = nightsCount * 89 * 0.85;
                    break;
            }

            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");


        }
        }
    }

