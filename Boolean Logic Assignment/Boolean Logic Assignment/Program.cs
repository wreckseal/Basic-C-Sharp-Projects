using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Boolean Logic Assignment!\n"); // Display a welcome message to the user
            Console.WriteLine("What is your age?"); // Prompt the user for their age
            int age = Convert.ToInt32(Console.ReadLine()); // Read the user's input and convert it to an integer
            Console.WriteLine("Have you ever had DUI? (yes/no)"); // Prompt the user for their DUI status
            bool hasDUI = string.Equals(Console.ReadLine()?.ToLower(), "yes", StringComparison.OrdinalIgnoreCase); // Read the user's input and convert it to a boolean value
            Console.WriteLine("How many speeding tickets do you have?"); // Prompt the user for the number of speeding tickets
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Read the user's input and convert it to an integer

            if (age > 15 && !hasDUI && speedingTickets <= 3) // Check if the user meets the qualifications to drive
            {
                Console.WriteLine("\nYou are qualified to drive!"); // Display a message indicating that the user is qualified to drive
            }
            else // If the user does not meet the qualifications to drive
            {
                Console.WriteLine("\nYou are not qualified to drive!"); // Display a message indicating that the user is not qualified to drive
            }
        }
    }
}