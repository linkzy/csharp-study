using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpStudy.Basics
{
    internal class ControlStructures
    {
        public ControlStructures()
        {
            // If Statements
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }

            // For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i + 1}");
            }

            // While Loop
            int counter = 0;

            while (counter < 3)
            {
                Console.WriteLine($"Count: {counter + 1}");
                counter++;
            }

        }
    }
}
