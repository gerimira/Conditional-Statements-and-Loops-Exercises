using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            var lastFirstNumber = 0;
            var lastSecondNumber = 0;
            int count = 0;
            bool isFound = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magicNumber)
                    {
                        lastFirstNumber = i;
                        lastSecondNumber = j;
                        isFound = true;
                    }

                    count++;

                }

            }
            if (isFound == true)
            {
                Console.WriteLine($"Number found! {lastFirstNumber} + {lastSecondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
            
        }
    }
}
