using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Temp
    {
        static void Main(string[] args)
        {
            double cel,far;
            Console.WriteLine("Enter temprature in degree celcius");
            cel=Convert.ToDouble(Console.ReadLine());

            far = ((cel * 9) / 5 )+ 32;

            Console.WriteLine($" Fahrenheit value of {cel} is {far}");




        }
    }
}
