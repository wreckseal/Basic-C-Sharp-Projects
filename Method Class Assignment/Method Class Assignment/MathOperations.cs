using System;

namespace Method_Class_Assignment
{
    internal class MathOperations
    {
        // This void method accepts two integer parameters.
        // It performs a math operation on the first integer and displays the second integer to the console.
        public void DisplayResult(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2.
            int result = firstNumber * 2;

            // Display the result of the math operation.
            Console.WriteLine("Result of the math operation: " + result);

            // Display the second integer.
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}