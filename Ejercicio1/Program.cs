using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Crea 3 variables númericas con el valor que tu quieras,
             * y en otra variable numérica guarda el valor de las suma de las 3 anteriores.
             * Mostrar por Consola      */

            int num1 = 12;
            int num2 = 15;
            int num3 = 28;
            int suma = num1 + num2 + num3;
            WriteLine("La suma es: " + suma);

            ReadLine();
        }
    }
}
