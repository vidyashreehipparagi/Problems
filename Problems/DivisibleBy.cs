using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class DivisibleBy
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());

            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("Given number is divisible by both 5 and 11");
            }
            else
                Console.WriteLine("Given number is not divisible by both 5 and 11");
        }
    }
}
