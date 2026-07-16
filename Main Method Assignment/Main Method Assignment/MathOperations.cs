using System;

namespace MethodOverloadingApp
{
    // This class contains overloaded methods that perform different math operations based on the parameter type.
    public class MathOperations
    {
        // Method #1
        // Accepts an integer, adds 10, and returns the result.
        public int Calculate(int number)
        {
            // Add 10 to the integer.
            int result = number + 10;

            // Return the calculated value.
            return result;
        }

        // Method #2 (Overloaded)
        // Accepts a decimal, multiplies it by 2, then returns the result as an integer.
        public int Calculate(decimal number)
        {
            // Multiply the decimal by 2.
            decimal result = number * 2;

            // Convert the decimal result to an integer.
            return Convert.ToInt32(result);
        }

        // Method #3 (Overloaded)
        // Accepts a string, converts it to an integer if possible, subtracts 5 from it, then returns the result.
        public int Calculate(string number)
        {
            // Try to convert the string into an integer.
            if (int.TryParse(number, out int convertedNumber))
            {
                // Perform a different math operation.
                int result = convertedNumber - 5;

                // Return the result.
                return result;
            }

            // If conversion fails, display an error message.
            Console.WriteLine("The string could not be converted to an integer.");

            // Return 0 to indicate failure.
            return 0;
        }
    }
}