/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Linq1
    {
        public static void test()
        {
            List<string> names = new List<string>
        {
            "Mansi", "Harsh", "Jaya", "Mansi", "Jaya", "Priya", "Madhu"
        };

            FindDuplicates(names);
        }

        public static void FindDuplicates(List<string> names)
        {
            var duplicates = names
                .GroupBy(name => name)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key);

            Console.WriteLine("Duplicate names are:");
            foreach (var name in duplicates)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            Linq1.test();
            //Linq1.FindDuplicates();
            Console.ReadLine();
        }

    }
    
}

*/