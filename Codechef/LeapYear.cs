
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class LeapYear
    {
        static void Test()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        // Method to check if a year is a leap year
        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            LeapYear.Test();
        }
    }
}
