using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class ReverseArray1
    {

        static void Main()
        {
            // Initialize the array
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            // Reverse the array
            ReverseArray(array);

            Console.WriteLine("Reversed array:");
            PrintArray(array);
        }

        static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                // Swap elements
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                // Move indices towards the center
                start++;
                end--;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}


