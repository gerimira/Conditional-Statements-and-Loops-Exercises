using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var drink = "";

            switch (profession)
            {
                case "Athlete":
                    drink ="Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }
            double totalPrice = 0;
            if (drink == "Water")
            {
                totalPrice = quantity * 0.70;
            }
            else if (drink == "Coffee")
            {
                totalPrice = quantity * 1.00;
            }
            else if (drink == "Beer")
            {
                totalPrice = quantity * 1.70;
            }
            else if (drink == "Tea")
            {
                totalPrice = quantity * 1.20;
            }
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
