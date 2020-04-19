using System;
using static System.Console;
namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; //0000 1010
            int b = 6; //0000 0110
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b ={a & b}"); // possat un a sobre l'altre , si coincideixen dos 1 produeix un 1, en aquest cas sona 10binaris  que es el 2 decimal 
            WriteLine($"a | b ={a | b}");  //8 , 4 and 2 bit colum 
            WriteLine($"a ^ b = {a ^ b }"); // 8 and 4 bit colum 


            //http://icarus.cs.weber.edu/~dab/cs1410/textbook/2.Core/bitops.html 
            // veure aquesta pagina  aqui ho explica molt be 

        }
    }
}
