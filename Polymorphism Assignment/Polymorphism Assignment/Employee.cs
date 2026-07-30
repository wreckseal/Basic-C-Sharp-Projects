using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Assignment
{
    // Employee class inherit from Person AND implement the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        // The 'override' keyword is used to provide the specific implementation of the abstract method.
        public override void SayName()
        {
            // Prints the full name to the console using the properties inherited from Person.
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // Implement the Quit() method as required by the IQuittable interface.
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} quits!");
        }
    }
}
