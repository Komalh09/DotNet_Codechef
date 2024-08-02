using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class JaggedArray
    {
        public void Print()
        {

            Console.Write("Enter the number of rows for the jagged array: ");
            int numRows = Convert.ToInt32(Console.ReadLine());

            // Create the jagged array
            int[][] jaggedArray = new int[numRows][];

            // Input each row
            for (int i = 0; i < numRows; i++)
            {
                Console.Write($"Enter the number of elements for row {i + 1}: ");
                int numElements = Convert.ToInt32(Console.ReadLine());

                jaggedArray[i] = new int[numElements];

                Console.WriteLine($"Enter {numElements} elements for row {i + 1}: ");
                for (int j = 0; j < numElements; j++)
                {
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Print the jagged array
            Console.WriteLine("\nJagged array contents:");
            PrintJaggedArray(jaggedArray);
        }

        public void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + ":");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            JaggedArray j1= new JaggedArray();
            j1.Print();
        }
    }

}

