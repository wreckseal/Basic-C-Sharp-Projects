using System;

namespace Methods_And_Objects_Assignment
{
    // Main program class
    internal class Program
    {
        // Main method to run the program
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee employee = new Employee();

            // Set the properties of the employee object
            employee?.FirstName = "Sample";
            employee?.LastName = "Student";

            // Set the Id property of the employee object
            employee?.Id = 1;

            // Call the SayName method to display the employee's name
            employee?.SayName();
        }
    }
}