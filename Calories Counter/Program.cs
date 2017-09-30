using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(String[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            int cheeseCalories = 0;
            int tomatoSouceCalories = 0;
            int salamiCalories = 0;
            int pepperCalories = 0;
            int calories = 0;
            var totalCaloriesAmount = 0;

            for (int i = 1; i <= num1; i++)
            {
                var ingredients = Console.ReadLine();
                if (ingredients.ToLower() == "cheese")
                {
                    cheeseCalories = 500;
                    totalCaloriesAmount += cheeseCalories;
                }
                else if (ingredients.ToLower() == "tomato sauce")
                {
                    tomatoSouceCalories = 150;
                    totalCaloriesAmount += tomatoSouceCalories;
                }
                else if(ingredients.ToLower() == "salami")
                {
                    salamiCalories = 600;
                    totalCaloriesAmount += salamiCalories;
                }
                else if (ingredients.ToLower() == "pepper")
                {
                    pepperCalories = 50;
                    totalCaloriesAmount += pepperCalories;
                }
                else
                {
                    calories = 0;
                    totalCaloriesAmount += calories;
                }

                
            }
            
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
