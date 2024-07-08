using System;

namespace VariableInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Declare and initialize variables
            string myString = "Hello, World!";
            int myInt = 42;
            char myChar = 'A';
            bool myBool = true;
            double myDouble = 3.14;
            decimal myDecimal = 19.99m;

            // Step 2: Interpolate variables in a Console.WriteLine
            Console.WriteLine($"String value: {myString}");
            Console.WriteLine($"Int value: {myInt}");
            Console.WriteLine($"Char value: {myChar}");
            Console.WriteLine($"Bool value: {myBool}");
            Console.WriteLine($"Double value: {myDouble}");
            Console.WriteLine($"Decimal value: {myDecimal}");
        }
    }
}
