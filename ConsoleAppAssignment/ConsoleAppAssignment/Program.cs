using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            int counter = 1;

            while (counter <= 5)
            {
                switch (counter)
                {
                    case 1:
                        number1 = ReadDoubleFromConsole("Multiplication\nEnter any number: ");
                        Console.WriteLine($"Your number {number1} multiply by 50 is: {number1 * 50} \n");
                        break;
                    
                    case 2:
                        number1 = ReadDoubleFromConsole("Addition\nEnter any number: ");
                        Console.WriteLine($"Your number {number1} added to 25 is: {number1 + 25} \n");
                        break;
                    
                    case 3:
                        number1 = ReadDoubleFromConsole("Division\nEnter any number: ");
                        Console.WriteLine($"Your number {number1} divided by 12.5 is: {number1 / 12.5} \n");
                        break;
                    
                    case 4:
                        number1 = ReadDoubleFromConsole("Boolean\nEnter any number: ");
                        Console.WriteLine($"Is your number {number1} > 50? {number1 > 50} \n");
                        break;
                    
                    case 5:
                        number1 = ReadDoubleFromConsole("Remainder\nEnter any number: ");
                        Console.WriteLine($"Your number {number1} divided by 7, the remainder is: {number1 % 7} \n");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
                number1 = 0;
                counter++;
            }
        }

        static double ReadDoubleFromConsole(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(s) && double.TryParse(s, out var value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
