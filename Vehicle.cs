using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        // Constructor to initialize a Vehicle object
        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        // Method to display general vehicle information
        public void Show()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}");
        }

        // Method to display general vehicle information
        public void Display()
        {
            Console.WriteLine($"Vehicle Information - Brand: {Brand}, Year: {Year}");
        }

        // Common method 1
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        // Common method 2
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    class FourWheeler : Vehicle
    {
        public int Wheels { get; set; }

        // Constructor to initialize a FourWheeler object
        public FourWheeler(string brand, int year, int wheels)
            : base(brand, year)
        {
            Wheels = wheels;
        }

        // Override Show method to include additional information for FourWheeler
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Wheels: {Wheels}");
        }
    }

    class TwoWheeler : Vehicle
    {
        public bool HasSidecar { get; set; }

        // Constructor to initialize a TwoWheeler object
        public TwoWheeler(string brand, int year, bool hasSidecar)
            : base(brand, year)
        {
            HasSidecar = hasSidecar;
        }

        // Override Show method to include additional information for TwoWheeler
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }

    class SUV : FourWheeler
    {
        public bool Is4WD { get; set; }

        // Constructor to initialize an SUV object
        public SUV(string brand, int year, int wheels, bool is4WD)
            : base(brand, year, wheels)
        {
            Is4WD = is4WD;
        }

        // Override Show method to include additional information for SUV
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"4WD: {Is4WD}");
        }

        // Call common methods from the base Vehicle class
        public void PerformActions()
        {
            StartEngine(); // Method from Vehicle class
            Console.WriteLine("SUV is ready for adventure!");
            StopEngine();  // Method from Vehicle class
        }
    }

class Program2
    {
        public void Test()
        {
            // Create instances of each class
            Vehicle vehicle = new Vehicle("Generic", 2022);
            FourWheeler fourWheeler = new FourWheeler("Car", 2021, 4);
            TwoWheeler twoWheeler = new TwoWheeler("Fashion-Fro", 2020, true);
            SUV suv = new SUV("Jeep", 2023, 4, true);

            // Display information for each instance
            Console.WriteLine("Vehicle:");
            vehicle.Show();
            vehicle.Display();

            Console.WriteLine("\nFourWheeler:");
            fourWheeler.Show();
            fourWheeler.Display();

            Console.WriteLine("\nTwoWheeler:");
            twoWheeler.Show();
            twoWheeler.Display();

            Console.WriteLine("\nSUV:");
            suv.Show();
            suv.Display();
            suv.PerformActions(); // Calls methods from the base Vehicle class
        }
        static void Main(string[] args)
        {
            Program2 p2=new Program2();
            p2.Test();
        }
    }

}
