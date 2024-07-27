
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class GCD1
    {
        public int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            GCD1 g1 = new GCD1();

            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Enter the second number: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    int gcd = g1.FindGCD(num1, num2);
                    Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");
                }
                else
                {
                    Console.WriteLine("Invalid input. ");
                }
            }
        }
    }
}

