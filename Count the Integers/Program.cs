﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var count = 0;
            try
            {
                for (int i = 0; i < 101; i++)
                {
                    int n = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception)
            {

                Console.WriteLine(count); ;
            }
        }
    }
}
