using Method_Assignment;
using System;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class.
            MathOperations math = new MathOperations();

            // Variable to control the input loop.
            bool check = true;

            // Variables to store the user's input numbers.
            int firstNumber = 0; // Initialize firstNumber to avoid uninitialized variable error.
            int secondNumber; // Declare secondNumber without initialization since it will be assigned later.

            // Ask the user for the first number.
            while (check)
            {
                try
                {
                    // Ask the user to enter the first number.
                    Console.Write("Enter the first number: ");

                    // Read the user's input.
                    string? firstInput = Console.ReadLine();

                    // Convert the first input into an integer.
                    // This will throw a FormatException if the user enters text.
                    firstNumber = Convert.ToInt32(firstInput);

                    check = false; // Exit the loop after successful execution.
                }
                // Catch errors caused by invalid number input.
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Please enter only whole numbers.");
                }
            }

            // Reset the check variable for the second input loop.
            check = true; 

            // Ask the user for the second number, which is optional.
            while (check)
            { 
                try
                { 
                // Ask the user for the second number.
                Console.Write("Enter the second number (optional - press Enter to skip): ");

                    // Read the second input.
                    string? secondInput = Console.ReadLine();

                    // Variable to store the result.
                    int result;

                    // Check if the second input is blank.
                    if (string.IsNullOrWhiteSpace(secondInput))
                    {
                        // Call the method using only the first number.
                        result = math.AddNumbers(firstNumber);
                    }
                    else
                    {
                        // Convert the second input into an integer.
                        secondNumber = Convert.ToInt32(secondInput);

                        // Call the method with both numbers.
                        result = math.AddNumbers(firstNumber, secondNumber);
                    }

                    // Display the result.
                    Console.WriteLine("\nResult: " + result);

                    check = false; // Exit the loop after successful execution.
                }
                // Catch errors caused by invalid number input.
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Please enter only whole numbers.");
                }
            }            
        }
    }
}