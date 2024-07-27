/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Array1
    {
        static void Main()
        {
            int[] array = { 7, 2, 3, 5, 5, 3, 2, 6, 7, 8, 1,7 };
            FindDuplicates(array);
        }

        static void FindDuplicates(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Duplicates from array are :");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    Console.WriteLine(array[i]);
                    // Skip subsequent duplicates
                    while (i < array.Length && array[i] == array[i - 1])
                    {
                        i++;
                    }
                }
            }
        }
    }
}
*/
