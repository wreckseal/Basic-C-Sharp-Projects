using System;


namespace Class_Method_Assignment
{
    static class MathOperations
    {
        public static void Divide(double a)
        {
            double result = a / 2;
            Console.WriteLine($"The quotient of {a} and {2} is: {result}");
        }

        public static void Divide(double a, out double result)
        {
            result = a / 2;
        }
    }
}
