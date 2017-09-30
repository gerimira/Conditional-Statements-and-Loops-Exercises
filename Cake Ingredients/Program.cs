using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        
        {
            
            var count = 0;

            for (int i = 0; i <=20 ; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    break;
                }
            }
            
        }
    }
}
