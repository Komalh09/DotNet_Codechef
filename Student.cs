using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
    }
    public class StudentListEx
    {
        public static void show()
        {
            //Create a student list
            List<Student> students = new List<Student>();

            //Get the user input for the list

            // Get the number of students from user
            Console.WriteLine("Enter the number of students:");
            int total = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Student student = new Student();

                Console.WriteLine($"Enter details for student {i + 1}:");

                Console.Write("\nID: ");
                student.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                student.Name = Console.ReadLine();

                Console.Write("Age: ");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Location: ");
                student.Location = Console.ReadLine();

                students.Add(student);
            }

            // Display the student list
            Console.WriteLine("\nStudent List:");
            Console.WriteLine("ID\tName\tAge\tLocation");
            Console.WriteLine("------------------------------------");

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Id}\t{s.Name}\t{s.Age}\t{s.Location}");
            }

            //Display the students who are eligible to vote.
            Console.WriteLine("\nStudent Eligible to Vote-");
            Console.WriteLine("ID\tName\tAge");
            Console.WriteLine("--------------------------");

            var q1 = students.Where(s => s.Age >= 18).ToList();
            foreach (var s in q1)
            {
                Console.WriteLine($"{s.Id}\t{s.Name}\t{s.Age}");
            }

            //Average of the age.
            Console.WriteLine($"\nAverage of Student's Age ");
            Console.WriteLine("-----------------------------");
            var q2 = students.Average(s => s.Age);
            Console.WriteLine($"{q2}");

            // Display student whoose name starts with particular character.
            Console.WriteLine("\nName of the student whoose name starts with s- ");
            var q3 = students.Where(s => s.Name.ToUpper().StartsWith("S")).ToList();

            Console.WriteLine("ID\tName\tAge\tLocation");
            Console.WriteLine("------------------------------------");
            foreach (var s in q3)
            {
                Console.WriteLine($"{s.Id}\t{s.Name}\t{s.Age}\t{s.Location}");
            }

        }
        static void Main(string[] args)
        {
            StudentListEx.show();
    
        }
    }
}