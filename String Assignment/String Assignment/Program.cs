using System;
using System.Text;

namespace StringOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // 1. Concatenate three strings
            // ------------------------------------------------------------

            // Declare and initialize three separate string variables.
            string firstName = "Rexel";
            string middleInitial = "L.";
            string lastName = "Cartalla";

            // Combine the three strings into one full name, spaces are added between each string for readability.
            string fullName = firstName + " " + middleInitial + " " + lastName;

            // Display the concatenated string on the console.
            Console.WriteLine("1. Concatenated String:");
            Console.WriteLine(fullName);

            // Print an empty line to separate sections.
            Console.WriteLine();

            // Declare a string containing a sentence.
            string message = "Welcome to C# programming.";

            // Convert every character in the string to uppercase.
            string upperMessage = message.ToUpper();

            // Display the uppercase version of the string.
            Console.WriteLine("2. Uppercase String:");
            Console.WriteLine(upperMessage);

            // Print an empty line to separate sections.
            Console.WriteLine();


            // Create a new StringBuilder object.
            StringBuilder paragraph = new StringBuilder();

            // Add the first sentence to the paragraph.
            paragraph.Append("C# is a powerful programming language. ");

            // Add the second sentence.
            paragraph.Append("It is commonly used for desktop, web, and mobile applications. ");

            // Add the third sentence.
            paragraph.Append("StringBuilder helps improve performance when building large strings. ");

            // Add the fourth sentence.
            paragraph.Append("Using comments makes code easier for other developers to understand.");

            // Display the completed paragraph.
            Console.WriteLine("3. Paragraph Built Using StringBuilder:");
            Console.WriteLine(paragraph.ToString());

            // Print an empty line.
            Console.WriteLine();

            // Prompt the user to press any key before exiting.
            Console.WriteLine("Press any key to exit...");

            // Wait for the user to press a key.
            Console.ReadKey();
        }
    }
}