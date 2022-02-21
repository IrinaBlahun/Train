using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels)
        {
           int a = levels - 1;
            while (a > 0)
            {
                levels += a;
                a--;
            }
            return levels;
        }

    }

}