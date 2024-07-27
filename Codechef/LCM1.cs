
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class LCM1
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

        public int FindLCM(int a, int b, int gcd)
        {
            return Math.Abs(a * b) / gcd;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Enter the second number: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    LCM1 l1 = new LCM1();

                    int gcd = l1.FindGCD(num1, num2);
                    int lcm = l1.FindLCM(num1, num2, gcd);
                    Console.WriteLine($"The LCM of {num1} and {num2} is: {lcm}");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
