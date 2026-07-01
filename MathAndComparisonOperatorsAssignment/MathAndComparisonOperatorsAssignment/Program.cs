using System;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n\n"); // Display the title of the program
            Console.WriteLine("Person 1:"); // Display the title of the first person
            Console.WriteLine("What is your hourly rate?"); // Ask the user for their hourly rate
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine()); // Convert the input to an integer and store it in hourlyRate1
            Console.WriteLine("\nHow many hours do you work per week?"); // Ask the user for their hours per week
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine()); // Convert the input to an integer and store it in hoursPerWeek1
            Console.WriteLine("\n\nPerson 2:"); // Display the title of the second person
            Console.WriteLine("What is your hourly rate?"); // Ask the user for their hourly rate
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine()); // Convert the input to an integer and store it in hourlyRate2
            Console.WriteLine("\nHow many hours do you work per week?"); // Ask the user for their hours per week
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine()); // Convert the input to an integer and store it in hoursPerWeek2
            Console.WriteLine("\n\nComparison:"); // Display the title of the comparison section
            Console.WriteLine($"\nAnnual salary of Person 1:\n{hourlyRate1 * hoursPerWeek1 * 52}\n"); // Calculate and display the annual salary of Person 1
            Console.WriteLine($"Annual salary of Person 2:\n{hourlyRate2 * hoursPerWeek2 * 52}\n"); // Calculate and display the annual salary of Person 2
            Console.WriteLine($"Does Person 1 make more money than Person 2?\n{(hourlyRate1 * hoursPerWeek1 * 52) > (hourlyRate2 * hoursPerWeek2 * 52)}"); // Compare the annual salaries of Person 1 and Person 2 and display the result
        }
    }
}