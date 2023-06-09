using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class AvgPercentage
    {
        static void Main(string[] args)
        {
            int chemistry, physics, maths, biology, english;
            Console.WriteLine("Enter marks obtained in chemistry");
            chemistry=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in Physics");
            physics=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in Maths");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in Biology");
            biology= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in English");
            english = Convert.ToInt32(Console.ReadLine());

            double avg=(physics+chemistry+maths+maths+english)/5;
            double percentage = (physics + chemistry + maths + maths + english) * 100 / 500;

            Console.WriteLine($"Your Average  mark is {avg} and Percentage is {percentage}");



        }
    }
}
