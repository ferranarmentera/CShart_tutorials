using System;
using static System.Console;

namespace SelectionStatements
{
    class Program 
    {
                static void Main(string[] args)
                {
                if (args.Length == 0)
                {
                WriteLine("There are no arguments.");
                }
                else
                {
                WriteLine("There is at least one argument.");
                }
            // add and remove the "" to change the behavior
            object o = 3;//Delete the double-quote characters around the "3" value so that the value stored in the variable named o is an int type instead of a string type.
            int j = 4;
            if(o is int i)
            {
                WriteLine($"{i} x {j}={i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply");
            }
        }


    }
















}


