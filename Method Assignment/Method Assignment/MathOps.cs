using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Assignment
{
    // This class contains methods that perform mathematical operations.
    public class MathOperations
    {
        // This method accepts two integers.
        // The second parameter is optional and defaults to 10 if the user does not provide a second value.
        public int AddNumbers(int firstNumber, int secondNumber = 10)
        {
            // Add the two numbers together.
            int result = firstNumber + secondNumber;

            // Return the calculated result.
            return result;
        }
    }
}