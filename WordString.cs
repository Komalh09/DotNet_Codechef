using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class WordString
    {
        public void CheckWords()
        {

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();


            int wordCount = CountWords(input);

            // Display the result
            Console.WriteLine($"The number of words in the string is: {wordCount}");
        }

        public int CountWords(string str)
        {
            // Split the string by whitespace and count the non-empty entries
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' });
            return words.Length;
        }
        static void Main(string[] args)
        {
            WordString w1 = new WordString();
               w1 .CheckWords();
        }
    }

}


