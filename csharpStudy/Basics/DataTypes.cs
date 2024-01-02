using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpStudy.Basics
{
    internal class DataTypes
    {
        public DataTypes()
        {
            // Common Data Types
            int age = 25;           // Integer
            double salary = 50000.50;// Double-precision floating-point
            string name = "John";   // String
            bool isStudent = false;  // Boolean

            // Additional Data Types
            char grade = 'A';       // Character
            float temperature = 98.6f; // Single-precision floating-point
            decimal price = 49.99m; // Decimal
            byte byteValue = 255;   // Byte
            short shortValue = 1000; // Short
            long longValue = 1000000L; // Long
            object genericObject = "This can hold any type"; // Object

            // Displaying Values
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary:C}"); // Currency format
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Is Student: {isStudent}");

            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Temperature: {temperature}°F");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine($"Byte Value: {byteValue}");
            Console.WriteLine($"Short Value: {shortValue}");
            Console.WriteLine($"Long Value: {longValue}");
            Console.WriteLine($"Generic Object: {genericObject}");

        }
    }
}
