using System;

namespace Abstract_Class_Assignment
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
        }
    }
}