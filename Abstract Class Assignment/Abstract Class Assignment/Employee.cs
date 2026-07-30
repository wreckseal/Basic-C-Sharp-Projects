using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Abstract_Class_Assignment
{
    // Employee class inherits from Person class
    public class Employee : Person
    {
        // The 'override' keyword is used to provide the specific implementation of the abstract method.
        public override void SayName()
        {
            // Prints the full name to the console using the properties inherited from Person.
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
