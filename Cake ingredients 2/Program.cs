using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_ingredients_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = "";
            var count = 0;
            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
                break;
            }
            
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
