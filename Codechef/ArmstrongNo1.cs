
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeshef
{
    internal class ArmstrongNo1
    {
        public bool CheckArmNo(int number)
        {

            int originalNumber = number;
            int numDigits = number.ToString().Length;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, numDigits);
                number /= 10;
            }

            return sum == originalNumber;
        }
        static void Main(string[] args)
        {
            ArmstrongNo1 a1 = new ArmstrongNo1();

            Console.Write("Enter a number to check if it's an Armstrong number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (a1.CheckArmNo(num))
                Console.WriteLine($"{num} is an Armstrong number.");
            else
                Console.WriteLine($"{num} is not an Armstrong number.");
        }
    }
}