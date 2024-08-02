using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class MinMax
    {
        public static void CheckMinMax()
        {
            Console.Write("Enter the elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n]; //n represent size


            Console.WriteLine("Enter the elements in array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Initialize min and max
            int min = numbers[0];
            int max = numbers[0];

            // Find min and max
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }


            Console.WriteLine($"The minimum Number is: {min}");
            Console.WriteLine($"The maximum Number is: {max}");

        }
        static void Main(string[] args)
        {
            MinMax.CheckMinMax();
        }
    }
}
