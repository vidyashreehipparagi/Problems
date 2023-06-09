using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class ThirdAngle
    {
        static void Main(string[] args)
        {
            int a1,a2,a3;
            Console.WriteLine("Enter first angle");
            a1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second angle");
            a2=Convert.ToInt32(Console.ReadLine());

            a3=180-(a1+a2);

            Console.WriteLine($"Third angle of triangle={a3}");
        }
    }
}
