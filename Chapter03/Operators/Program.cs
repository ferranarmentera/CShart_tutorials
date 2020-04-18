using System;
using static System.Console;
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 3;
            // int b = a++;
            //WriteLine($"a is {a},b is {b}");//el $ indica que estem declarant un interpolated string que tornara els valors que posen dintre del curly braces 
        // el resultat es a is 4, b is 3 , perque el operador ++ s'executa despres de l'assignació ( postfix operator )
        // si volem que passi abans hem de declarar el prefix operatos ++a 
        int c = 3;
        int d = ++c; // increment c before assigning it
        WriteLine($"c is {c}, d is {d}");
        int e = 11;
        int f = 3;
        WriteLine($"e is {e}, f is {f}");
        WriteLine($"e + f = {e + f}");
        WriteLine($"e - f = {e - f}");
        WriteLine($"e * f = {e * f}");
        WriteLine($"e / f = {e / f}");
        WriteLine($"e % f = {e % f}");

        double g = 11.0;
        WriteLine($"g is {g:N2}, f is {f}"); // N02 indica el nombre de decimals que afegim a la variable N1= 0.0 N2 = 0.00  ..etc 
        WriteLine($"g / f = {g / f}");

        //Assigment operators 
        int p = 6;
        p += 3; // equivalent to p = p + 3;
        p -= 3; // equivalent to p = p - 3;
        p *= 3; // equivalent to p = p * 3;
        p /= 3; // equivalent to p = p / 3;
        // Logical Operators 

        bool a = true;
        bool b = false;
        WriteLine($"AND | a | b ");
        WriteLine($"a | {a & a,-5} | {a & b,-5} ");
        WriteLine($"b | {b & a,-5} | {b & b,-5} ");
        WriteLine();
        WriteLine($"OR | a | b ");
        WriteLine($"a | {a | a,-5} | {a | b,-5} ");
        WriteLine($"b | {b | a,-5} | {b | b,-5} ");
        WriteLine();
        WriteLine($"XOR | a | b ");
        WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
        WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");

        }
    }
}
