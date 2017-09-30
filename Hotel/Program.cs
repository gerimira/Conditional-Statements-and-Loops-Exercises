using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());
            var roomType = "";
            int pricePerNight = 0;
            double priceTotal = 0;

            switch (month)
            {
                case "May":
                case "October":
                    switch (roomType)
                    {
                        case "Studio":
                            
                            if (nightsCount >= 7)
                            {
                                if (month == "October")
                                {
                                    priceTotal = (nightsCount - 1) * 50;
                                }
                                else
                                {
                                    priceTotal = nightsCount * 50 - (nightsCount * 50 * 0.05);
                                }
                                
                            }
                            else
                            {
                                priceTotal = nightsCount * 50;
                            }
                            break;
                        case "Double":
                            priceTotal = 65 * nightsCount;
                            break;
                        case "Suite":
                            priceTotal = 75 * nightsCount;
                            break;
                    }
                    break;
                case "June":
                case "September":
                    switch (roomType)
                    {
                        case "Studio":
                            priceTotal = 60 * nightsCount;
                            if (nightsCount >= 7 && month == "September")
                            {
                                priceTotal = (nightsCount - 1) * 60;
                                Console.WriteLine($"Studio: {priceTotal:F2} lv.");
                            }
                            else
                            {
                                priceTotal = nightsCount * 60;
                                Console.WriteLine($"Studio: {priceTotal:F2} lv.");
                            }
                            
                            break;
                        case "Double":
                            if (nightsCount >= 14)
                            {
                                priceTotal = nightsCount * 72 - (nightsCount * 72 * 0.10);
                                Console.WriteLine($"Double: {priceTotal:F2} lv.");
                            }
                            else
                            {
                                priceTotal = pricePerNight * nightsCount;
                                Console.WriteLine($"Double: {priceTotal:F2} lv.");
                            }

                            break;
                        case "Suite":
                            priceTotal = 82 * nightsCount;
                            Console.WriteLine($"Suite: {priceTotal:F2} lv.");
                            break;
                    }

                    break;
                case "July":
                case "August":
                case "December":
                    switch (roomType)
                    {
                        case "Studio":
                            priceTotal = 68 * nightsCount;
                            break;
                        case "Double":
                            priceTotal = 77 * nightsCount;
                            break;
                        case "Suite":
                            if (nightsCount >= 14)
                            {
                                priceTotal = nightsCount * 89 - (nightsCount * 89 * 0.15);
                            }
                            break;

                    }
                    break;
            }
            Console.WriteLine($"Studio: {priceTotal:F2} lv.");
            Console.WriteLine($"Double: {priceTotal:F2} lv.");
            Console.WriteLine($"Suite: {priceTotal:F2} lv.");
        }
    }
}
