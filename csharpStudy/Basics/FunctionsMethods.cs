using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpStudy.Basics
{
    using System;

    class FunctionsMethods
    {
        // Function Declaration
        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        // Function with Parameters and Return Value
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Lambda Expression (Arrow Function)
        static Func<int, int, int> Multiply = (x, y) => x * y;

        // Global Variable
        static int globalVariable = 10;

        // Function with Global Variable
        static void DisplayGlobal()
        {
            Console.WriteLine($"Global Variable: {globalVariable}");
        }

        static void Main()
        {
            // Calling the Function
            SayHello();

            // Calling the Function with Parameters
            int result = Add(3, 7);
            Console.WriteLine($"Sum: {result}");

            // Calling the Lambda Function
            int product = Multiply(4, 5);
            Console.WriteLine($"Product: {product}");

            // Calling the Function with Global Variable
            DisplayGlobal();
        }
    }

}
