using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class PerimeterOfRec
    {
        static void Main(string[] args)
        {
            double length, breadth, Perimeter;
            Console.WriteLine("Enter Length");
            length=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter breadth");
            breadth=Convert.ToDouble(Console.ReadLine());

            Perimeter = 2*length + 2*breadth;
            Console.WriteLine($"Perimeter of rectangle={Perimeter}");

        }
    }
}
