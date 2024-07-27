
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Factorial1
    {
        public static void checkFtNo()
        {
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                long factorial = FactorialIterative(number);
                Console.WriteLine($"Factorial of {number} is {factorial}");
            }
           long FactorialIterative(int n)
            {
                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }


        }
        static void Main(string[] args)
        {
            Factorial1.checkFtNo();
        }
    }
}
