using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class FtoC
    {
        static void Main(string[] args)
        {
            double far, cel;
            Console.WriteLine("Enter temprature in Fahrenheit");
            far=Convert.ToDouble(Console.ReadLine());

            cel = (far - 32) * 5 / 9;

            Console.WriteLine($"degree celcius value of {far} is {cel}");
        }
    }
}
