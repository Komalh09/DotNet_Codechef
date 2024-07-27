using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Age1
    {
        static void Test()
        {
            Console.WriteLine("Enter your date of birth (dd/MM/yyyy): ");
            string inputDob = Console.ReadLine();

            DateTime dob;
            if (DateTime.TryParse(inputDob, out dob))
            {
                int age = CalculateAge(dob);
                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }

        static int CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            // Using if-else to adjust age if the birthday has not occurred yet this year
            if (today.Month < dob.Month)
            {
                age--;
            }
            else if (today.Month == dob.Month)
            {
                if (today.Day < dob.Day)
                {
                    age--;
                }
            }

            return age;
        }
        static void Main(string[] args)
        {
            Age1.Test();
        }
    }
}