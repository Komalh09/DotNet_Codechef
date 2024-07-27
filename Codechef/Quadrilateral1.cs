/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    public class Quadrilateral1
   { 
            static void Test()
            {
                Console.Write("Enter the sum of angles: ");
                int angleSum = int.Parse(Console.ReadLine());

                if (angleSum == 180)
                {
                    Console.WriteLine("This is a triangle.");

                    // Get the side lengths from the user
                    Console.Write("Enter the length of the first side: ");
                    double side1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the length of the second side: ");
                    double side2 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the length of the third side: ");
                    double side3 = double.Parse(Console.ReadLine());

                    // Calculate perimeter and area
                    double perimeter = CalculatePerimeter(side1, side2, side3);
                    double area = CalculateArea(side1, side2, side3);

                    Console.WriteLine($"Perimeter of the triangle: {perimeter}");
                    Console.WriteLine($"Area of the triangle: {area}");
                }
                else if (angleSum == 360)
                {
                    Console.WriteLine("This is a quadrilateral.");
                }
                else
                {
                    Console.WriteLine("This is neither a triangle nor a quadrilateral.");
                }
            }

            static double CalculatePerimeter(double side1, double side2, double side3)
            {
                return side1 + side2 + side3;
            }

            static double CalculateArea(double side1, double side2, double side3)
            {
                // Using Heron's formula to calculate the area
                double s = (side1 + side2 + side3) / 2;
                double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
                return area;
            }

            static void Main(string[] args)
            {
                Test();
            }
    }
}
*/