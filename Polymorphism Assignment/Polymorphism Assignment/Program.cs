using System;

namespace Polymorphism_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student".
            Employee employee = new()
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Call the SayName() method on the object.
            employee.SayName();

            // Demonstrate polymorphism by creating an object of type 
            // IQuittable and assigning an Employee object to it. 
            // Employee implements IQuittable, so this assignment is valid. 
            IQuittable quittable = employee;

            // Call the Quit() method through the IQuittable interface. 
            // The Employee class's implementation of Quit() will execute.
            quittable.Quit();
        }
    }
}