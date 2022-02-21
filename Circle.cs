using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r = Convert.ToDouble(Console.ReadLine());
            var s = pi*(Math.Pow(r,2));
            Console.WriteLine(s);
            
            
        }
    }
}