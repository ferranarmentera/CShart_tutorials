using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
Console.WriteLine($"{a} + {b} equals 0.3");
}
else
{
Console.WriteLine($"{a} + {b} does NOT equal 0.3");
}
        }
    }
}
// unsigned integer means positive whole number
// including 0
uint naturalNumber = 23;
// integer means negative or positive whole number
// including 0
int integerNumber = -23;
// float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F;
// double means double-precision floating point
double anotherRealNumber = 2.3; // double literal
// Numbers can be natural numbers, such as 42, used for counting (also called whole
// numbers); they can also be negative numbers, such as -42 (called integers); or, they
// can be real numbers, such as 3.9 (with a fractional part), which are called single or
// double-precision floating point numbers in computing.

// Good Practice: Use int for whole numbers and double for real
// numbers that will not be compared to other values. Use decimal
// for money, CAD drawings, general engineering, and wherever
// accuracy of a real number is important.