
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class PascalTriangle1
    {
        static void Main()
        {
            Console.Write("Enter the number of rows for Pascal's Triangle: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            PrintPascalsTriangle(rows);
        }

        static void PrintPascalsTriangle(int rows)
        {
            int[,] triangle = new int[rows, rows];

            // Initialize the triangle with values
            for (int i = 0; i < rows; i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
            }

            // Calculate the values for the rest of the triangle
            for (int i = 2; i < rows; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }

            // Determine the maximum width of the numbers
            int maxNumberWidth = (rows * 2 - 1).ToString().Length;

            // Print the triangle
            for (int i = 0; i < rows; i++)
            {
                // Print leading spaces
                Console.Write(new string(' ', (rows - i - 1) * maxNumberWidth / 2));

                for (int j = 0; j <= i; j++)
                {
                    // Print each number with appropriate spacing
                    Console.Write(triangle[i, j].ToString().PadLeft(maxNumberWidth) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
