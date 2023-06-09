using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class AreaOfEquilateral
    {
        static void Main(string[] args)
        {
            double a, area;
            Console.WriteLine("Enter side of equilateral triangle");
            a=Convert.ToDouble(Console.ReadLine());

            area = 0.433 * a;
            Console.WriteLine($"area of equilateral triangle ={area}");

        }
    }
}
