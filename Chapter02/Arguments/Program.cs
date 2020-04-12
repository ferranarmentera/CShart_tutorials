/*
++++++++++++++Getting arguments
You might have been wondering what the string[] args arguments are in the
Main method. They're an array used to pass arguments into a console application;
let's take a look to see how it works.

Command-line arguments are separated by spaces. Other characters like hyphens
and colons are treated as part of an argument value. To include spaces in an
argument value, enclose the argument value in single or double quotes.
Imagine that we want to be able to enter the names of some colors for the foreground
and background, and the dimensions of the Terminal window at the command line.
We would be able to read the colors and numbers by reading them from the args
array, which is always passed into the Main method of a console application.
*/

using System;
using static System.Console; // per no tenir d'escrire Console abans de casa argument

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are  {args.Length} arguments.");  //Setting options with arguments
            if (args.Length < 4)            /*We will now use these arguments to allow the user to pick a color for the
                                            background, foreground, width, and height of the output window.*/
            {
            WriteLine("You must specify two colors and dimensions,e.g.");
            WriteLine("dotnet run red yellow 80 40");
            return; // stop running
            }
            ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor),            
            value: args[0],
            ignoreCase: true);
            BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor),value: args[1],ignoreCase: true);
            try
            {
            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
            }
            catch (PlatformNotSupportedException)   /*Rerun the console application; note the exception is caught, and a friendly
                                                     message is shown to the user,
                                                     */
            {
            WriteLine("The current platform does not support changing the size of a console window.");
            }
/*
In TERMINAL, enter some arguments after the dotnet run
command, as shown in the following command line:
dotnet run firstarg second-arg third:arg "fourth arg"
*/


/*Enter the following command in TERMINAL:
dotnet run red yellow 50 10*/



        }
    }
}
