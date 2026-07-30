using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_Assignment
{
    public class Employee
    {
        // Stores the ID of the employee.
        public int Id { get; set; }
        //Stores the first name of the employee.
        public string? FirstName { get; set; }
        //Stores the last name of the employee.
        public string? LastName { get; set; }

        // Overloads the == operator so that two Employee objects can be compared based on their Id property.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both objects refer to the same object in memory, they are considered equal.
            if (ReferenceEquals(employee1, employee2)) return true;

            // If either object is null, they cannot be equal.
            if (employee1 is null || employee2 is null) return false;

            // Compare the Id properties of the two Employee objects. If the IDs are the same, the employees are considered equal.
            return employee1.Id == employee2.Id;
        }

        // The != operator must also be overloaded because comparison operators must be overloaded in pairs.
        public static bool operator !=(Employee employee1, Employee employee2) 
        {
            // Return the opposite result of the == operator.
            return !(employee1 == employee2); 
        }

        // Overrides Equals so that it uses the same comparison logic as the overloaded == operator.
        public override bool Equals(object? obj)
        {
            // Check whether the supplied object is an Employee. If it is, compare this Employee with that Employee.
            return obj is Employee employee && this == employee;
        }

        // Overrides GetHashCode because Equals has been overridden. The employee's Id is used to generate the hash code.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
