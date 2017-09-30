using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            string skipLetter = Console.ReadLine();



            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        string currentSequence = $"{i}{j}{k} ";
                        if (!currentSequence.Contains(skipLetter))
                        {
                            Console.Write(currentSequence);
                        }
                    }
                }
            }
            
        }
    }
}
