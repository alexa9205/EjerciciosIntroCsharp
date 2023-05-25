using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ejercicio2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /* Pedir dos números al usuario por teclado y decir que número es el mayor */

            WriteLine("Introducer un número:");
            int num1 = ToInt32(ReadLine());
            WriteLine("Introduce otro número:");
            int num2 = ToInt32(ReadLine());
            if (num1 > num2)
            {
                WriteLine($"Tu primer número {num1} , es mayor");
            }
            else
            {
                WriteLine($"Tu segundo número introducido, el {num2}, es mayor que {num1} ");
            }

            ReadLine();
        }
    }
}
