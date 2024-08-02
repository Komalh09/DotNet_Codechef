using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class StringArray
    {
        public static void Check()

        {

            Console.Write("Enter the No.of strings in array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Initialize the string array
            string[] strings = new string[n];

            // Input strings from the user
            Console.WriteLine("Enter strings:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"String {i + 1}: ");
                strings[i] = Console.ReadLine();
            }

            // Initialize counters for vowels and consonants
            int vowelCount = 0;
            int consonantCount = 0;

            // Define a set of vowels for comparison
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            // Count vowels and consonants
            foreach (string str in strings)
            {
                foreach (char ch in str.ToLower())
                {
                    if (char.IsLetter(ch)) // Consider only letters
                    {
                        if (Array.Exists(vowels, v => v == ch))
                        {
                            vowelCount++;
                        }
                        else
                        {
                            consonantCount++;
                        }
                    }
                }
            }

            // Output the results
            Console.WriteLine($"Total vowels: {vowelCount}");
            Console.WriteLine($"Total consonants: {consonantCount}");
        }
        static void Main(string[] args)
        {
            
            StringArray.Check();
        }
    }

}

