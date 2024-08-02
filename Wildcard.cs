using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Wildcard
    {
        public void CheckWildCard()
        {

            Console.Write("Enter a string to check if it contains wildcards (*,?,[],!): ");
            string input = Console.ReadLine();

            // Check if the input string contains wildcard characters
            bool containsWildcard = ContainsWildcard(input);

            // Display the result
            if (containsWildcard)
            {
                Console.WriteLine("The string contains wildcard characters.");
            }
            else
            {
                Console.WriteLine("The string does'nt contain wildcard characters.");
            }
        }

        public bool ContainsWildcard(string input)
        {
            // Check if the string contains either '*' or '?'
            return input.Contains('*') || input.Contains('?');
        }
        static void Main(string[] args)
        {
            Wildcard w1= new Wildcard();
            w1.CheckWildCard();
        }
    }

}
