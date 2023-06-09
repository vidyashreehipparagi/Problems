using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            int rad;
            Console.WriteLine("Enter radius of circle");
            rad=Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * rad * rad;
            Console.WriteLine($"Area of circle={area}");
        }
    }
}
