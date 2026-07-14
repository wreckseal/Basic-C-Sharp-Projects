using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main()
        {
            // One-dimensional array of strings
            string[] pedalArray = [
                "1966 Dallas Rangemaster Treble Booster",
                "Late-’60s/early-’70s Univox Uni-Vibe",
                "1994-’99 Klon Centaur Professional Overdrive (gold case)",
                "’70s Maestro Echoplex Groupmaster (solidstate)",
                "1974-’77 Mu-Tron Bi-Phase (with optical pedal)",
                "’77 Mu-Tron Flanger",
                "’60s Maestro Echoplex (tube model)",
                "1960s Binson EchoRec (tube unit)",
                "Late-’60s Dallas-Arbiter Fuzz Face",
                "’70s Roland Space Echo (several models)"
            ];

            Console.WriteLine("One-dimensional array of strings");
            Console.WriteLine("Select an array index to view its value (0-9):");
            bool input1 = int.TryParse(Console.ReadLine(), out int pedalIndex); // Parse the input as an integer

            // Validate the input
            if (input1 == true)
            {
                if(pedalIndex >= pedalArray.Length) // Check if the index is out of bounds
                    input1 = false;
            }

            // Loop until valid input is received
            while (!input1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please select a valid index (0-9).");
                Console.ResetColor();
                Console.Write("Enter an integer: ");
                input1 = int.TryParse(Console.ReadLine(), out pedalIndex); // Parse the input as an integer

                // Check if the index is out of bounds
                if (pedalIndex >= pedalArray.Length) 
                    input1 = false;
            }

            // Display the value at the selected index
            Console.WriteLine($"Value at index {pedalIndex}: {pedalArray[Convert.ToInt32(pedalIndex)]}\n\n");


            // One-dimensional array of integers
            int[] numbers = [3, 6, 8, 9, 10, 24, 54, 56, 78, 92];

            Console.WriteLine("One-dimensional array of integers");
            Console.WriteLine("Select an array index to view its value (0-9):");
            bool input2 = int.TryParse(Console.ReadLine(), out int index); // Parse the input as an integer

            // Validate the input
            if (input2 == true)
            {
                if (index >= numbers.Length) // Check if the index is out of bounds
                    input2 = false;
            }

            // Loop until valid input is received
            while (!input2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please select a valid index (0-9).");
                Console.ResetColor();
                Console.Write("Enter an integer: ");
                input2 = int.TryParse(Console.ReadLine(), out index); // Parse the input as an integer

                // Check if the index is out of bounds
                if (index >= numbers.Length) 
                    input2 = false;
            }
            // Display the value at the selected index
            Console.WriteLine($"Value at index {index}: {numbers[index]}\n\n");


            // Create a list of strings
            List<string> names = new List<string>()
            {
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Eve",
                "Frank",
                "Grace",
                "Heidi",
                "Ivan",
                "Judy"
            };

            Console.WriteLine("List of strings");
            Console.WriteLine("Select a list index to view its value (0-9):");
            bool input3 = int.TryParse(Console.ReadLine(), out int listIndex); // Parse the input as an integer

            // Validate the input
            if (input3 == true)
            {
                if (listIndex >= names.Count) // Check if the index is out of bounds
                    input3 = false;
            }

            // Loop until valid input is received
            while (!input3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please select a valid index (0-9).");
                Console.ResetColor();
                Console.Write("Enter an integer: ");
                input3 = int.TryParse(Console.ReadLine(), out listIndex); // Parse the input as an integer

                // Check if the index is out of bounds
                if (listIndex >= names.Count)
                    input3 = false;
            }

            // Display the value at the selected index
            Console.WriteLine($"Value at index {listIndex}: {names[listIndex]}\n\n");
        }
    }
}