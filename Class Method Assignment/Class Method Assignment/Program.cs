using System;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // MathOperations class cannot be instantiated because it is a static class,
            // so we don't need to create an instance of it. (Compiler Error CS0723)
            // MathOperations mathOperations = new MathOperations(); // This line is commented out because it is not needed.

            Console.WriteLine("Enter a number to divide by 2:");
            int number = Convert.ToInt32(Console.ReadLine());
            // Call the Divide method with the number as an argument
            MathOperations.Divide(number);

            // Call the Divide method with the number and an out parameter to get the result
            MathOperations.Divide(number, out double result);
            // Display the result of the division
            Console.WriteLine($"{number} / {2} = {result}");
        }
    }
}