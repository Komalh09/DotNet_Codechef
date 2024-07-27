
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class DiamondPattern1
    {
        public static void Main()  // Main method, entry point of the program
        {
            int i, j, r;  // Declaration of variables i, j, and r as integers

            Console.Write("\n\n");  // Displaying new lines
             
            Console.Write("-----------------------------------");  // Displaying a separator
            Console.Write("\n\n");  // Displaying new lines

            Console.Write("the number of rows (half of the diamond): ");  
            r = Convert.ToInt32(Console.ReadLine());  

            // Loop to print the upper part of the diamond pattern
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");  

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  // Printing asterisks to form the upper part of the diamond

                Console.Write("\n"); 
            }

            // Loop to print the lower part of the diamond pattern
            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");  // Printing spaces before the asterisks

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  

                Console.Write("\n");  // Moving to the next line after each row
            }
        }
    }
}