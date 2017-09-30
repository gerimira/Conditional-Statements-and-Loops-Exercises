using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healthGosho = 100;
            int turns = 0;

            while (healthGosho>0 && healthPesho>0)
            {
                turns++;  //Pravim s edin hod poveche zaradi while cikyla
                if (turns % 2 !=0)
                {
                    healthGosho -= damagePesho;
                    if (healthGosho < 1)
                    {
                        Console.WriteLine($"Pesho won in {turns}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else
                {
                    healthPesho -= damageGosho;
                    if (healthPesho < 1)
                    {
                        Console.WriteLine($"Gosho won in {turns}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }
                if (turns % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
            
            
        }
    }
}
