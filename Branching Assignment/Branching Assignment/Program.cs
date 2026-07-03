using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\r\n"); //Welcome message
            Console.WriteLine("Please enter the package weight:"); //Prompt user for package weight
            int weight = Convert.ToInt32(Console.ReadLine()); //Convert user input to integer
            if (weight > 50) //Check if weight is greater than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //Display message if weight is greater than 50
                return; //Exit the program if weight is greater than 50
            }

            Console.WriteLine("Please enter the package width:"); //Prompt user for package width
            int width = Convert.ToInt32(Console.ReadLine()); //Convert user input to integer
            Console.WriteLine("Please enter the package height:"); //Prompt user for package height
            int height = Convert.ToInt32(Console.ReadLine()); //Convert user input to integer
            Console.WriteLine("Please enter the package length:"); //Prompt user for package length
            int length = Convert.ToInt32(Console.ReadLine()); //Convert user input to integer

            if ((width + height + length) > 50) //Check if the sum of width, height, and length is greater than 50
            {
                Console.WriteLine("Package too big to be shipped via Package Express."); //Display message if the sum of width, height, and length is greater than 50
                return; //Exit the program if the sum of width, height, and length is greater than 50
            }

            int quote = (width * height * length * weight) / 100; //Calculate the shipping quote based on the formula provided

            Console.WriteLine($"\nYour estimated total for shipping this package is: ${quote:F2}"); //Display the shipping quote formatted to two decimal places
        }
    }
}