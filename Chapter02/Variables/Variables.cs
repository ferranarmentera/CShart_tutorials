using System;
using static System.Console;
namespace Variables
{
    class Program
    {
    /*+++++++++Storing any type of object++++++++
     There is a special type named object which can store 
    any type of data, but its flexibility comes at the 
    cost of messier code and possibly poor performance. 
    Because of those two reasons, you should avoid it whenever possible. */
        static void Main(string[] args)
        {
        object height = 1.88; // storing a double in an object
        object name = "Amir"; // storing a string in an object
        WriteLine($"{name} is {height} metres tall.");
        // int length1 = name.Length; // gives compile error! because the data type of the name variable is not known by the compiler.
        int length2 = ((string)name).Length; // tell compiler it is a string
        WriteLine($"{name} has {length2} characters."); 

/*+++++++++++++Storing dynamic types ++++++++++++
There is another special type named dynamic that can also store any type of data,
 but even more than object, 
its flexibility comes at the cost of performance. The dynamic keyword was introduced in C# 4.0. However,
 unlike an object, the value stored in the variable can have its members invoked without an explicit cast. */
 // storing a string in a dynamic object 
        dynamic anotherName = "Ahmed";
        // this compiles but would throw an exception at run-time 
        // if you later store a data type that does not have a property named Length 
        int length = anotherName.Length; 
        //One limitation of dynamic is that Visual Studio Code cannot show IntelliSense to help you write the code. 
        //This is because the compiler cannot check what the type is during build time. 
        //Instead, CLR checks for the member at runtime and throws an exception if it is missing.

        }
    }
}
