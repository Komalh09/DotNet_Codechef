/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Vowels1
    {
        public static void test()
        {
            string input = "Computer Department";
            int vowelCount = CountVowels(input);
            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
        }

        public static int CountVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = input.Count(c => vowels.Contains(c));
            return count;
        }
        static void Main(string[] args)
        {
            Vowels1.test();
            Console.ReadLine();
        }
    }
}
*/