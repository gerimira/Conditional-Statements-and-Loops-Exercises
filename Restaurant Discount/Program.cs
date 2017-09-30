using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var hallType = "";
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var priceHall = 0;
            int totalPrice = 0;
            double discount = 0;
            

            if (groupSize <= 50)
            {
                hallType = "Small Hall";
                priceHall = 2500;
                if (package == "Normal")
                {
                    totalPrice = priceHall + 500;
                    discount = totalPrice - totalPrice * 0.05;
                }
                else if (package == "Gold")
                {
                    totalPrice = priceHall + 750;
                    discount = totalPrice - totalPrice * 0.10;
                }
                else if (package == "Platinum")
                {
                    totalPrice = priceHall + 1000;
                    discount = totalPrice - totalPrice * 0.15;
                }
                double pricePerPerson = discount / groupSize;
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if(groupSize<=100)
            {
                hallType = "Terrace";
                priceHall = 5000;
                if (package == "Normal")
                {
                    totalPrice = priceHall + 500;
                    discount = totalPrice - totalPrice * 0.05;
                }
                else if (package == "Gold")
                {
                    totalPrice = priceHall + 750;
                    discount = totalPrice - totalPrice * 0.10;
                }
                else if (package == "Platinum")
                {
                    totalPrice = priceHall + 1000;
                    discount = totalPrice - totalPrice * 0.15;
                }
                double pricePerPerson = discount / groupSize;
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize <= 120)
            {
                hallType = "Great Hall";
                priceHall = 7500;
                if (package == "Normal")
                {
                    totalPrice = priceHall + 500;
                    discount = totalPrice - totalPrice * 0.05;
                }
                else if (package == "Gold")
                {
                    totalPrice = priceHall + 750;
                    discount = totalPrice - totalPrice * 0.10;
                }
                else if (package == "Platinum")
                {
                    totalPrice = priceHall + 1000;
                    discount = totalPrice - totalPrice * 0.15;
                }
                double pricePerPerson = discount / groupSize;
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            
            
        }
    }
}
