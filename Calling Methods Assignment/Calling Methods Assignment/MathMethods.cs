using System;
using System.Collections.Generic;
using System.Text;

namespace Calling_Methods_Assignment
{
    class MathMethods
    {
        static Random random = new Random();
        public static int rand1 = random.Next(1, 100);
        public static int rand2 = random.Next(1, 100);
        public static int rand3 = random.Next(1, 100);
        // Create a method that takes a string parameter and returns an integer.
        // The method should prompt the user to enter a number and return the number entered by the user.
        public static int GetUserInput(string operation)
        {
            Console.Write($"\nEnter any positive number to perform {operation}: ");
            try
            {
                return int.Parse(Console.ReadLine()!);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
                return GetUserInput(operation); // Recursively call the method to get valid input
            }
            
        }

        // Add, Multiply, and Subtract methods that take one integer as parameter and return the result of the operation.
        public static int Add(int number)
        {
            return number + rand1;
        }

        public static int Multiply(int number)
        {
            return number * rand2;
        }

        public static int Subtract(int number)
        {
            return number - rand3;
        }
    }
}