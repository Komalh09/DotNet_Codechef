using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class MatrixAddition
    {
        public void ADD2M()
        {
            // Define  matrices

            int rows = 2;
            int cols = 2;

            // Initialize the matrices
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] resultMatrix = new int[rows, cols];

            // Input for the first matrix
            Console.WriteLine("Enter elements for the first matrix:");
            ReadMatrix(matrix1, rows, cols);

            // Input for the second matrix
            Console.WriteLine("Enter elements for the second matrix:");
            ReadMatrix(matrix2, rows, cols);

            // Perform matrix addition
            AddMatrices(matrix1, matrix2, resultMatrix, rows, cols);

            // Display the result
            Console.WriteLine("\nResultant matrix after addition:");
            PrintMatrix(resultMatrix, rows, cols);
        }

        public void ReadMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element at [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void AddMatrices(int[,] matrix1, int[,] matrix2, int[,] resultMatrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
        }

        static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            MatrixAddition m1=new MatrixAddition();
            m1.ADD2M();
        }
    }

}