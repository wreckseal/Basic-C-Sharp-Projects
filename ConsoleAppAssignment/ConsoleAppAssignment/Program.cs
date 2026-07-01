using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1; // Declare a variable to hold the user input number
            int counter = 1; // Initialize a counter to keep track of the number of operations performed

            while (counter <= 5) // Loop until the counter reaches 5, allowing for 5 different operations
            {
                switch (counter) // Use a switch statement to determine which operation to perform based on the counter value
                {
                    case 1: // Perform multiplication operation
                        number1 = ReadDoubleFromConsole("Multiplication\nEnter any number: "); // Prompt the user to enter a number for multiplication
                        Console.WriteLine($"Your number {number1} multiply by 50 is: {number1 * 50} \n"); // Display the result of the multiplication operation
                        break;
                    
                    case 2: // Perform addition operation
                        number1 = ReadDoubleFromConsole("Addition\nEnter any number: "); // Prompt the user to enter a number for addition
                        Console.WriteLine($"Your number {number1} added to 25 is: {number1 + 25} \n"); // Display the result of the addition operation
                        break;
                    
                    case 3: // Perform division operation
                        number1 = ReadDoubleFromConsole("Division\nEnter any number: "); // Prompt the user to enter a number for division
                        Console.WriteLine($"Your number {number1} divided by 12.5 is: {number1 / 12.5} \n"); // Display the result of the division operation
                        break;
                    
                    case 4: // Perform boolean comparison operation
                        number1 = ReadDoubleFromConsole("Boolean\nEnter any number: "); // Prompt the user to enter a number for boolean comparison
                        Console.WriteLine($"Is your number {number1} > 50? {number1 > 50} \n"); // Display the result of the boolean comparison operation
                        break;
                    
                    case 5: // Perform remainder operation
                        number1 = ReadDoubleFromConsole("Remainder\nEnter any number: "); // Prompt the user to enter a number for remainder calculation
                        Console.WriteLine($"Your number {number1} divided by 7, the remainder is: {number1 % 7} \n"); // Display the result of the remainder operation
                        break;
                }
                Console.WriteLine("Press any key to continue..."); // Prompt the user to press any key to continue
                Console.ReadKey(true); // Wait for the user to press a key without displaying it in the console
                Console.Clear(); // Clear the console for the next operation
                number1 = 0; // Reset the number1 variable to 0 for the next iteration
                counter++; // Increment the counter to move to the next operation
            }
        }

        // This method reads a double value from the console with input validation
        static double ReadDoubleFromConsole(string prompt)
        {
            while (true) // Loop indefinitely until a valid double value is entered
            {
                Console.Write(prompt); // Display the prompt message to the user
                var s = Console.ReadLine(); // Read the user input from the console
                if (!string.IsNullOrWhiteSpace(s) && double.TryParse(s, out var value)) // Check if the input is not null or whitespace and can be parsed to a double
                    return value; // Return the parsed double value if valid
                Console.WriteLine("Invalid input. Please enter a valid number."); // Display an error message if the input is invalid
                Console.ReadKey(true); // Wait for the user to press a key without displaying it in the console
                Console.Clear(); // Clear the console for the next input attempt
            }
        }
    }
}
