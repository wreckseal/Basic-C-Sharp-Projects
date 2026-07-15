using System;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main()
        {
            // Call the method to get user input
            int number1 = MathMethods.GetUserInput("addition");

            // Call the Add method and store the returned value.
            int result1 = MathMethods.Add(number1);

            // Display the result returned from the Add method.
            Console.WriteLine($"{number1} + {MathMethods.rand1} = {result1}");

            // Call the method to get user input
            int number2 = MathMethods.GetUserInput("multiplication");
            // Call the Multiply method and store the returned value.
            int result2 = MathMethods.Multiply(number2);
            Console.WriteLine($"{number2} * {MathMethods.rand2} = {result2}");

            // Call the method to get user input
            int number3 = MathMethods.GetUserInput("subtraction");
            // Call the Subtract method and store the returned value.
            int result3 = MathMethods.Subtract(number3);
            Console.WriteLine($"{number3} - {MathMethods.rand3} = {result3}");
        }
    }
}