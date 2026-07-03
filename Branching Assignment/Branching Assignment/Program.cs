using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\r\n");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());
            
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            int quote = (width * height * length * weight) / 100;

            Console.WriteLine($"\nYour estimated total for shipping this package is: ${quote:F2}");
        }
    }
}