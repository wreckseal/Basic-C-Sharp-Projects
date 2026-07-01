using System;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n\n");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHow many hours do you work per week?");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nPerson 2:");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHow many hours do you work per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nComparison:");
            Console.WriteLine($"\nAnnual salary of Person 1:\n{hourlyRate1 * hoursPerWeek1 * 52}\n");
            Console.WriteLine($"Annual salary of Person 2:\n{hourlyRate2 * hoursPerWeek2 * 52}\n");
            Console.WriteLine($"Does Person 1 make more money than Person 2?\n{(hourlyRate1 * hoursPerWeek1 * 52) > (hourlyRate2 * hoursPerWeek2 * 52)}");
        }
    }
}