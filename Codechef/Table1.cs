/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Table1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Size: {Size}";
        }
    }
    class Program
    {
        static void Main()
        {
            // Sample collection of tables
            List<Table1> t1 = new List<Table1>
        {
            new Table1 { Id = 1, Name = "Dining Table", Size = 7},
            new Table1 { Id = 2, Name = "Coffee Table", Size = 4 },
            new Table1 { Id = 3, Name = "Study Table", Size = 3 }
        };

            Console.WriteLine("Original collection:");
            PrintTables(t1);

            Console.WriteLine("How would you like to sort the tables?");
            Console.WriteLine("1. By Id");
            Console.WriteLine("2. By Name");
            Console.WriteLine("3. By Size");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    t1 = t1.OrderBy(t => t.Id).ToList();
                    break;
                case 2:
                    t1 = t1.OrderBy(t => t.Name).ToList();
                    break;
                case 3:
                    t1 = t1.OrderBy(t => t.Size).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid choice. No sorting applied.");
                    break;
            }

            Console.WriteLine("Sorted collection:");
            PrintTables(t1);
        }

        static void PrintTables(List<Table1> tables)
        {
            foreach (var table in tables)
            {
                Console.WriteLine(table);
            }
        }
    }
}
*/