using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class CompoundInteres
    {
        static void Main(string[] args)
        {
            int p, t, r,n;
            Console.WriteLine("Enter Principle amount");
            p=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter duration in years");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rate of interest");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("annual compound");
            n = Convert.ToInt32(Console.ReadLine());

            

            double ci=p*(Math.Pow((1+r/n),n*t));
           
            Console.WriteLine($"Compound Interest={ci}");


        }
    }
}
