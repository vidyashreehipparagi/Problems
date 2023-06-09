using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year,leapyear;
            Console.WriteLine("Enter year");
            year=Convert.ToInt32(Console.ReadLine());

            if((year%4==0)&&(year%100!=0)&&(year%400==0)) {
                Console.WriteLine("Given year is leap year");
            }
            else
            {
                Console.WriteLine("Given year is not leap year");
            }

        
        }
    }
}
