using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    public interface ISpecies
    {
        void African();
        void Asian();
    }

    // Define the BodyCharacteristics interface
    public interface IBodyCharacteristics
    {
        void Trunk();
        void Tusk();
        void Teeth();
        void Skin();
        void Legs();
        void Ears();
    }

    // Define the Diet interface
    public interface IDiet
    {
        void Herbivorous();
    }

    // Define the Reproduction interface
    public interface IReproduction
    {
        void Interval();
    }

    // Define the Domestication interface
    public interface IDomestication
    {
        void Weight();
        void Use();
    }

    // Implement the Elephants class
    public class Elephants : ISpecies, IBodyCharacteristics, IDiet, IReproduction, IDomestication
    {
        // Implement ISpecies
        public void African()
        {
            Console.WriteLine("African Elephants are found in 38 countries of Africa, stand up to 4m and weigh around 7000kg.\n");
        }

        public void Asian()
        {
            Console.WriteLine("Asian Elephants are 3.4m tall and weigh 5400kg.\n");
        }

        // Implement IBodyCharacteristics
        public void Trunk()
        {
            Console.WriteLine("Trunk: Used to tear up their food and then place it in their mouth.\n");
        }

        public void Tusk()
        {
            Console.WriteLine("Tusk: Used to dig for water, salt, and roots; debark trees; eat bark; and clear paths by moving trees and branches.\n");
        }

        public void Teeth()
        {
            Console.WriteLine("Teeth: They usually have 28 teeth.\n");
        }

        public void Skin()
        {
            Console.WriteLine("Skin: Extremely tough around most parts of its body and measures about 2.5 cm (1 in) thick.\n");
        }

        public void Legs()
        {
            Console.WriteLine("Legs and Feet: Great straight pillars as they must be to support their bulk weight.\n");
        }

        public void Ears()
        {
            Console.WriteLine("Ears: Made of a very thin layer of skin stretched over cartilage with a rich network of blood vessels.\n");
        }

        // Implement IDiet
        public void Herbivorous()
        {
            Console.WriteLine("Diet: Elephants are herbivores, spending up to 16 hours a day collecting plant food.\n");
        }

        // Implement IReproduction
        public void Interval()
        {
            Console.WriteLine("Reproduction Interval: The interbirth interval is approximately five years, but occasionally as long as 10 years in free-ranging African and Asian elephants.\n");
        }

        // Implement IDomestication
        public void Weight()
        {
            Console.WriteLine("Reproduction Weight: Female elephants give birth to a single calf weighing 200-250 pounds (90-113 kg).\n");
        }

        public void Use()
        {
            Console.WriteLine("Domestication Use: Elephants have not been domesticated in the same way as cats or dogs.\n");
        }

        // Method to display all information
        public void DisplayInfo()
        {
            African();
            Asian();
            Trunk();
            Tusk();
            Teeth();
            Skin();
            Legs();
            Ears();
            Herbivorous();
            Interval();
            Weight();
            Use();
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            Elephants e1 = new Elephants();
            e1.DisplayInfo();
        }
    }
}
