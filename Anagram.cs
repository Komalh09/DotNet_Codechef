using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Anagram
    {

        public void Check()
        {
            // Prompt the user to enter the first string
            Console.Write("Enter the first string: ");
            string firstString = Console.ReadLine();

            // Prompt the user to enter the second string
            Console.Write("Enter the second string: ");
            string secondString = Console.ReadLine();

            // Check if the second string is an anagram of the first string
            bool isAnagram = IsAnagram(firstString, secondString);

            // Display the result
            if (isAnagram)
            {
                Console.WriteLine("The second string is an anagram of the first string.");
            }
            else
            {
                Console.WriteLine("The second string is not an anagram of the first string.");
            }
        }

        public bool IsAnagram(string str1, string str2)
        {
            // Remove any whitespace and convert strings to lowercase for case-insensitive comparison
            string Str1 = new string(str1.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
            string Str2 = new string(str2.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());

            // Check if lengths are different
            if (Str1.Length != Str2.Length)
            {
                return false;
            }

            // Convert strings to character arrays and sort them
            char[] arr1 = Str1.ToCharArray();
            char[] arr2 = Str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Compare sorted character arrays
            return arr1.SequenceEqual(arr2);
        }
        static void Main(string[] args)
        {
            Anagram a1=new Anagram();
            a1.Check();
        }
    }

}
