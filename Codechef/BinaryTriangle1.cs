
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class BinaryTriangle1
    {
        public void PrintBinaryTriangle(int numRows)
        {
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((i + j) % 2 + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            BinaryTriangle1 b1 = new BinaryTriangle1();

            Console.Write("Enter the number of rows: ");
            if (int.TryParse(Console.ReadLine(), out int numRows))
            {
                b1.PrintBinaryTriangle(numRows);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

