// +++++++++In C# 6.0 and later, the using statement can be used to further simplify our code. Then,
// we won't need to enter the Console type throughout our code. We can use Visual
// Studio Code's Replace feature to remove times we have previously wrote Console.
// 1. Add a statement to statically import the System.Console class to the top of
// the Program.cs file, as shown in the following code:
// ------>using static System.Console;
// 2. Select the first Console. in your code, ensuring that you select the dot after
// the word Console too.
// 3. Navigate to Edit | Replace and note that an overlay dialog appears ready for
// you to enter what you would like to replace Console. to nothing .
using System; 
using static System.Console;
namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        // One way for generating formatted strings is to use numbered positional arguments.
        // This feature is supported by methods like Write and WriteLine, and for methods
        // that do not support the feature, the string parameter can be formatted using the
        // Format method of string.
        {
        int numberOfApples = 12;
        decimal pricePerApple = 0.35M;
        WriteLine(format: "{0} apples costs {1:C}",arg0: numberOfApples,arg1: pricePerApple * numberOfApples);
        string formatted = string.Format(format: "{0} apples costs {1:C}",arg0: numberOfApples,arg1: pricePerApple * numberOfApples);

        //WriteToFile(formatted); // writes the string into a file
        // The WriteToFile method is a nonexistent method used to illustrate the idea.
        //+++++++++++ Formatting using interpolated strings+++++++++++
        WriteLine($"{numberOfApples} apples costs {pricePerApple *numberOfApples:C}");
        // is an  string prefixed
        // with $ can use curly braces around the name of a variable or expression to output the
        // current value of that variable or expression at that position in the string.

/*------------------Understanding format strings------------------------------
A variable or expression can be formatted using a format string after a comma or
colon.
An N0 format string means a number with thousand separators and no decimal places,
while a C format string means currency. The currency format will be determined by the
current thread. For instance, if you run this code on a PC in the UK, you'll get pounds
sterling with commas as the thousand separators, but if you run this code on a PC in
Germany, you would get Euros with dots as the thousand separators.
The full syntax of a format item is:
{ index [, alignment ] [ : formatString ] }
Each format item can have an alignment, which is useful when outputting tables
of values, some of which might need to the left- or right-aligned within a width of
characters. Alignment values are integers. Positive integers are right-aligned and
negative integers are left-aligned.
For example, to output a table of fruit and how many of each there are, we might
want to left-align the names within a column of 8 characters and right-align the
counts formatted as numbers with zero decimal places within a column of six
characters.
1. In the Main method, enter statements at the bottom of the Main method:
More Information: You can read more details about formatting
types in .NET at the following link: https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types.  */

        string applesText = "Apples";
        int applesCount = 1234;
        string bananasText = "Bananas";
        int bananasCount = 56789;
        WriteLine(format: "{0,-8} {1,6:N0}",arg0: "Name",arg1: "Count");
        WriteLine(format: "{0,-8} {1,6:N0}",arg0: applesText,arg1: applesCount);
        WriteLine(format: "{0,-8} {1,6:N0}",arg0: bananasText,arg1: bananasCount);

        /*Getting text input from the user
We can get text input from the user using the ReadLine method. This method waits
for the user to type some text, then as soon as the user presses Enter, whatever the
user has typed is returned as a string value.
1. In the Main method, type statements to ask the user for their name and age
and then output what they entered, as shown in the following code:*/
        Write("Type your first name and press ENTER: ");
        string firstName = ReadLine();
        Write("Type your age and press ENTER: ");
        string age = ReadLine();
        WriteLine(        $"Hello {firstName}, you look good for {age}.");

       /*2. Run the console application.
        3. Enter name and age, as shown in the following output:
        Type your name and press ENTER: Gary
        Type your age and press ENTER: 34
        Hello Gary, you look good for 34. */


    /*+++++++++++++++Getting key input from the user+++++++++++

    We can get key input from the user using the ReadKey method. This method waits
for the user to type some text, then as soon as the user presses Enter, whatever the
user has typed is returned as a string value.*/
        Write("Press any key combination: ");
        ConsoleKeyInfo key = ReadKey();
        WriteLine();
        WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",arg0: key.Key,arg1: key.KeyChar,arg2: key.Modifiers);
        }
    }
}



