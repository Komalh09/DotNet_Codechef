
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class HCF1
    {
        public int FindHCF(int a, int b)
        {
            while (b != 0)       //b is not equal to zero
            {
                int temp = b;
                b = a % b;
                a = temp;         //process repeated until b becomes zero
            }
            return a;
        }
        static void Main(string[] args)
        {
            HCF1 h1 = new HCF1();

            Console.WriteLine("Enter two numbers to find their HCF:");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call function to find HCF
            int hcf = h1.FindHCF(num1, num2);

            Console.WriteLine($"HCF of {num1} and {num2} is: {hcf}");
        }
    }
}
