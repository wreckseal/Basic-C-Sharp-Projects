using System;

namespace Operators_Assignment
{
    public class Program
    {
        static void Main()
        {
            // Creates the first Employee object.
            Employee employee1 = new()
            {
                FirstName = "John",
                LastName = "Smith",
                Id = 1
            };

            // Creates the second Employee object.
            Employee employee2 = new()
            {
                FirstName = "Jane",
                LastName = "Doe",
                Id = 2
            };

            // Displays information for the first employee
            Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName}");
            Console.WriteLine($"Employee 1 Id: {employee1.Id}");

            // Displays information for the second employee
            Console.WriteLine($"Employee 2: {employee2.FirstName} {employee2.LastName}");
            Console.WriteLine($"Employee 2 Id: {employee2.Id}");

            // Uses the overloaded == operator to compare the two employees.
            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");

            // Uses the overloaded != operator to determine whether the two employees have different IDs.
            Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");

        }
    }
}