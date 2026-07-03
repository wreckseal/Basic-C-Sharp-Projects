using System;

namespace BooleanComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // Initialize a counter variable
            Console.WriteLine("While Loop:"); // Print a message indicating the start of the while loop
            while (counter < 10) // Loop until counter is less than 10
            {
                counter++; // Increment the counter variable
                Console.WriteLine($"counter: {counter}"); // Print the current value of counter
            }

            Console.WriteLine("\nDo-While Loop:"); // Print a message indicating the start of the do-while loop
            do // Start a do-while loop
            {
                Console.WriteLine($"counter: {counter}"); // Print the current value of counter. No condition is checked before the first iteration of the loop, so this will always execute at least once.
                counter--; // Decrement the counter variable
            }
            while (counter > 0); // Continue looping while counter is greater than 0
        }
    }   
}