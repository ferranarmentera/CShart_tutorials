using System;
using static System.Console;
namespace BoolenaOperators
{
    class Program
    {
        static void Main(string[] args)
        {
        bool a = true;
        bool b = false;
        WriteLine($"AND | a | b ");
        WriteLine($"a | {a & a,-5} | {a & b,-5} ");// True & True = el -5 indica la posició dels caracters al imprimir-ho en pantalla 
        WriteLine($"b | {b & a,-5} | {b & b,-5} ");  // & =and   , barra verical | ( alt +! ) = OR , ^ = XOR  
        WriteLine();
        WriteLine($"OR | a | b ");  // $ es un formatted string 
        WriteLine($"a | {a | a,-5} | {a | b,-5} ");
        WriteLine($"b | {b | a,-5} | {b | b,-5} ");
        WriteLine();
        WriteLine($"XOR | a | b ");
        WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
        WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");


        }

        private static bool DoStuff()
        
        {
            WriteLine("I am doing some stuff.");
            return true;
            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");
        }
    }
}
