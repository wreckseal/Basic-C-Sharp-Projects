using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Assignment
{
    // Interfaces define a contract that any implementing class must follow.
    public interface IQuittable
    {
        // Interfaces only contain the signature, not the implementation.
        void Quit();
    }
}
