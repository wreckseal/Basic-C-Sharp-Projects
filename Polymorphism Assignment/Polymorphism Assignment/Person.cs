using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Assignment
{
    // An abstract class cannot be instantiated and is used as a base for other classes.
    public abstract class Person
    {        
        // Property for the person's first name
        public string? firstName { get; set; }

        // Propery for the person's last name
        public string? lastName { get; set; }

        // Marking this as 'abstract' means it has no implementation here, 
        // and any non-abstract class inheriting from Person MUST implement it.
        public abstract void SayName();
    }
}
