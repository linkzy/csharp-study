using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpStudy.Basics
{
    internal class Operators
    {
        public Operators()
        {
            // Arithmetic Operators
            int x = 10;
            int y = 5;

            int sum = x + y;        // Addition
            int difference = x - y; // Subtraction
            int product = x * y;     // Multiplication
            int quotient = x / y;    // Division
            int remainder = x % y;   // Modulus (remainder)

            // Comparison Operators
            int a = 10;
            int b = 20;

            bool isEqual = a == b;   // Equality check
            bool isNotEqual = a != b;// Inequality check
            bool isGreaterThan = a > b; // Greater than
            bool isLessThan = a < b;  // Less than

            // Logical Operators
            bool condition1 = true;
            bool condition2 = false;

            bool andResult = condition1 && condition2; // Logical AND
            bool orResult = condition1 || condition2;  // Logical OR
            bool notResult = !condition1;               // Logical NOT

            // Assignment Operators
            int variable = 10;
            variable += 5;  // Equivalent to variable = variable + 5;

            // Displaying Results
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");

            Console.WriteLine($"Is Equal: {isEqual}");
            Console.WriteLine($"Is Not Equal: {isNotEqual}");
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");

            Console.WriteLine($"AND Result: {andResult}");
            Console.WriteLine($"OR Result: {orResult}");
            Console.WriteLine($"NOT Result: {notResult}");

            Console.WriteLine($"Variable Value: {variable}");

        }
    }
}
