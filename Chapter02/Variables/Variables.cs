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

        //++++++Declaring local variable+++++++
        /*Local variables are declared inside methods, and they only exist during the execution of that method,
         and once the method returns, the memory allocated to any local variables is released. 
        Strictly speaking, value types are released while reference types must wait for a garbage collection. 

        */
        int population = 66_000_000; // 66 million in UK 
        double weight = 1.88; // in kilograms 
        decimal price = 4.99M; // in pounds sterling 
        string fruit = "Apples"; // strings use double-quotes 
        char letter = 'Z'; // chars use single-quotes 
        bool happy = true; // Booleans have value of true or false 

        /*
        Visual Studio Code will show green squiggles under each of the variable names to warn you that the variable is assigned,
         but its value is never used. You can use the var keyword to declare local variables. 
         The compiler will infer the type from the value that you assign after the assignment operator, =.
         A literal number without a decimal point is inferred as an int variable, 
         that is, unless you add the L suffix, in which case, it infers a long variable. 
         A literal number with a decimal point is inferred as double unless you add the M suffix, in which case, 
         it infers a decimal variable, or the F suffix, in which case, it infers a float variable. Double quotes indicate a string variable,
         single quotes indicate a char variable, and the true and false values infer a bool type. 
         2. Modify the previous statements to use var, as shown in the following code:
                 */

        var population = 66_000_000; // 66 million in UK 
        var weight = 1.88; // in kilograms
        var price = 4.99M; // in pounds sterling 
        var fruit = "Apples"; // strings use double-quotes 
        var letter = 'Z'; // chars use single-quotes 
        var happy = true; // Booleans have value of true or false

        /*
        Good Practice: Although using var is convenient, some developers avoid using it, to make it easier for a code reader to understand the types in use. 
        Personally, I use it only when the type is obvious. For example, in the following code statements, 
        the first statement is just as clear as the second in stating what the type of the xml variable is, but it is shorter.
        However, the third statement isn't clear, so the fourth is better. If in doubt, spell it out!
        */
        // good use of var because it avoids the repeated type
         // as shown in the more verbose second statement 
        var xml1 = new XmlDocument(); 
        XmlDocument xml2 = new XmlDocument();
        // bad use of var because we cannot tell the type, so we 
        // should use a specific type declaration as shown in 
        // the second statement 
        var file1 = File.CreateText(@"C:\something.txt"); 
        StreamWriter file2 = File.CreateText(@"C:\something.txt"); 

        }
    }
}
