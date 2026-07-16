using System;

namespace MethodOverloadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the MathOperations class.
            MathOperations math = new MathOperations();

            Console.WriteLine("Demonstrate method overloading by calling the Calculate method with different parameter types.\n");
            // Call the overloaded method with an integer parameter and display the result.
            Console.WriteLine($"Integer: {math.Calculate(20)}");

            // Call the overloaded method with a decimal parameter and display the result.
            Console.WriteLine($"Decimal: {math.Calculate(12.5m)}");

            // Call the overloaded method with a string parameter and display the result.
            Console.WriteLine($"String: {math.Calculate("30")}");
        }
    }
}