using System;

namespace Console_App_Strings_Integers_Assignment
{
    class Program
    {
        static void Main()
        {
            // Create a list of integers
            List<int> numList = new List<int>()
            {
                42,
                187,
                365,
                512,
                689,
                744,
                810,
                915,
                48,
                273
            };

            bool check = true; // Boolean variable to control the while loop
            float userInput; // Variable to store user input

            // Display the list of integers
            Console.WriteLine("Here is a list of integers:");
            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nThis program will divide a list of integers by a positive integer you provide.\n");

            // Start a while loop to get user input and perform division
            while (check)
            {
                try
                {
                    Console.WriteLine("Enter any positive integer: ");
                    userInput = float.Parse(Console.ReadLine());

                    // Check if the user input is a positive integer
                    if (userInput > 0)
                    {
                        // Perform division and display the results
                        foreach (int num in numList)
                        {
                            Console.WriteLine($"{num} / {userInput} = {num / userInput}");
                        }
                        check = false;
                    }
                    // If the user input is not a positive integer, display an error message
                    else
                    {
                        Console.WriteLine("Please enter any positive integer.\n");
                    }
                }
                // Catch any FormatException that occurs when parsing the user input
                catch (FormatException)
                { 
                    Console.WriteLine($"Invalid input.");
                }
                // Finally block to indicate successful exit from the try-catch block
                finally
                {
                    Console.WriteLine("\nProgram successfully exited in the try-catch block!\n");
                }
            }
        }
    }
}