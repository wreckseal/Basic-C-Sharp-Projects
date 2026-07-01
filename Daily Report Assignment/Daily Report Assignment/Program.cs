using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College\n\n");
            Console.WriteLine("Student Daily Report\n");
            Console.WriteLine("What is your name?"); // Ask the user for their name
            string? name = Console.ReadLine(); // Store the user's name in a string variable
            Console.WriteLine("\nWhat course are you on?"); // Ask the user for the course they are on
            string? course = Console.ReadLine(); // Store the user's course in a string variable
            Console.WriteLine("\nWhat page number?"); // Ask the user for the page number they are on
            int pageNumber = Convert.ToInt32(Console.ReadLine()); // Store the user's page number in a variable and convert it to an integer
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\""); // Ask the user if they need help with anything
            bool needsHelp = Convert.ToBoolean(Console.ReadLine()); // Store the user's answer in a boolean variable
            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics."); // Ask the user if they had any positive experiences they'd like to share
            string? positiveExperiences = Console.ReadLine(); // Store the user's answer in a string variable
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific."); // Ask the user if they have any other feedback they'd like to provide
            string? otherFeedback = Console.ReadLine(); // Store the user's answer in a string variable
            Console.WriteLine("\nHow many hours did you study today?"); // Ask the user how many hours they studied today
            int hoursStudied = Convert.ToInt32(Console.ReadLine()); // Store the user's answer in a variable and convert it to an integer
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!"); // Thank the user for their answers and let them know that an instructor will respond shortly
        }
    }
}