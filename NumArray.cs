using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class NumArray
    {
        public void main()
        {
            int[] numbers = new int[10]; //hold 10 integer

            // Prompt the user to enter 10 integers
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Find the maximum number to determine the size of the count array
            int max = FindMax(numbers);

            // Create an array to count occurrences
            int[] counts = new int[max + 1];

            // Count occurrences of each number
            foreach (int number in numbers)
            {
                counts[number]++;
            }

            // Display the counts
            Console.WriteLine("\nNumber Counts :");
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"Number {i} is repeated {counts[i]} time.");
                }
            }
        }

        //method to find the maximum number in the array
        public int FindMax(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            NumArray n1= new NumArray();
            n1.main();
        }
    }


}