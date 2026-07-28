using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_And_Objects_Assignment
{
    // Base class Person
    internal class Person
    {
        // Properties for FirstName and LastName
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // Method to display the full name
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
