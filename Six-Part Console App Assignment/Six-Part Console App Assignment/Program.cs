using System;

namespace Six_Part_Console_App_Assignment
{
    class Program
    {
        static void Main()
        {
            // ASSIGNMENT PART 1: Create a one-dimensional array of strings and append user input to each string
            // Create a one-dimensional array of strings
            string[] fruits = ["Apple", "Banana", "Cherry", "Orange", "Grapes"];

            // Ask the user to input some text
            Console.Write("Enter some text to append to each string: ");
            string? userInput = Console.ReadLine();

            // Loop through the array and append the user's input
            // This updates each element but does not print anything
            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i] += userInput;
            }

            // Display a blank line for better readability
            Console.WriteLine("Updated Array:");

            // Loop through the updated array and print each string
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            // ASSIGNMENT PART 2: Create a loop that continues until a certain condition is met
            int counter = 0;

            while (counter < 5)
            {
                Console.WriteLine($"Counter value: {counter}"); // Print the current value of the counter
                counter++;   // Increment the counter to prevent an infinite loop
            }


            // ASSIGNMENT PART 3: Create a loop that uses both the "<" and "<=" operators
            // Loop using the "<" operator
            Console.WriteLine("\nLoop using the '<' operator:");

            // Loop from 0 to 4 (5 iterations) using the "<" operator
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Value: {i}");
            }

            // Loop using the "<=" operator
            Console.WriteLine("\nLoop using the '<=' operator:");

            // Loop from 0 to 5 (6 iterations) using the "<=" operator
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Value: {i}"); // Print the current value of i
            }

            Console.WriteLine(); // Print a blank line for better readability
            Console.WriteLine(); // Print a blank line for better readability


            // ASSIGNMENT PART 4: Create a list of unique strings and ask the user to search for a specific string
            // List of unique strings
            List<string> fruits1 = new List<string>()
            {
                "Apple",
                "Banana",
                "Cherry",
                "Orange",
                "Grapes"
            };

            Console.WriteLine("List of fruits:");
            // Ask the user for a search term
            foreach (string fruit in fruits1)
            {
                Console.WriteLine(fruit);
            }
            Console.Write("\nEnter a fruit name: ");
            string? searchText = Console.ReadLine();

            // Variable to determine whether a match was found
            bool found = false;

            // Loop through the list to search for a match
            for (int i = 0; i < fruits1.Count; i++)
            {
                // Compare the user's input with the current list item
                if (fruits1[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{searchText} is at index: {i}"); // Display the index of the found item

                    found = true;

                    // Stop the loop once a match has been found
                    break;
                }
            }

            // If no match was found, notify the user
            if (!found)
            {
                Console.WriteLine("The item you entered is not in the list.");
            }

            // ASSIGNMENT PART 5: Create a list of strings that has at least two identical strings and ask the user to search for a specific string
            // List containing duplicate strings
            List<string> colors = new List<string>
            {
                "Red",
                "Blue",
                "Green",
                "Red",
                "Yellow",
                "Blue",
                "Purple"
            };

            Console.WriteLine("\nList of colors:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Ask the user to search for a color
            Console.Write("Enter a color name: ");
            string? colorSearch = Console.ReadLine();

            // Variable to determine whether any matches were found
            bool matchFound = false;
            int ctr = 0;

            // Loop through the entire list
            for (int i = 0; i < colors.Count; i++)
            {
                // Check if the current item matches the user's input
                if (colors[i].Equals(colorSearch, StringComparison.OrdinalIgnoreCase))
                {
                    ctr += 1; // Increment the counter for each match found

                    if (ctr == 1)
                    {
                        Console.WriteLine($"{colorSearch} is at index: {i}"); // Display the index of the first match
                    }
                    else
                    {
                        Console.WriteLine($"Another {colorSearch} found at index: {i}"); // Display the index of subsequent matches
                    }
                    

                    // Set flag indicating at least one match was found
                    matchFound = true;
                    
                    // No break statement is used because we want
                    // to find and display all matching indices.
                }
            }

            // If no matches were found, notify the user
            if (!matchFound)
            {
                Console.WriteLine("The item you entered is not in the list.");
            }


            // ASSIGNMENT PART 6: Create a list of strings that has at least two identical strings and use a loop to find all matching items
            // Create a list of strings that contains duplicate values
            List<string> animals = new List<string>
            {
                "Dog",
                "Cat",
                "Bird",
                "Fish",
                "Cat",
                "Horse",
                "Dog"
            };

            // A HashSet only stores unique values.
            List<string> seenItems = new List<string>();

            Console.WriteLine("\nChecking the list for duplicate items:");

            // Loop through each item in the list using a foreach loop.
            foreach (string animal in animals)
            {
                // Check whether the current item has already been added to the HashSet.
                if (seenItems.Contains(animal))
                {
                    // If the item already exists, it is a duplicate.
                    Console.WriteLine($"{animal} - this item is a duplicate");
                }
                else
                {
                    // If the item is not already in the List, it is unique.
                    Console.WriteLine($"{animal} - this item is unique");

                    // Store the unique item in the List so future occurrences will be identified as duplicates.
                    seenItems.Add(animal);
                }
            }
        }
    }
}