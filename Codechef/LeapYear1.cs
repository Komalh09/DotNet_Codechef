/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class LeapYear1
    {
        static void Test()
        {
            Console.WriteLine("Enter a date (dd/MM/yyyy): ");
            string inputDate = Console.ReadLine();

            try
            {
                // Parse the input date string to a DateTime object
                DateTime parsedDate = DateTime.ParseExact(inputDate, "dd/MM/yyyy", null);

                // Extract the year from the parsed date
                int year = parsedDate.Year;

                // Determine if the year is a leap year
                bool isLeapYear = IsLeapYear(year);

                // Output the result
                if (isLeapYear)
                {
                    Console.WriteLine($"The year {year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"The year {year} is not a leap year.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format.");
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
            LeapYear1.Test();
        }
    }
}
*/
