using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Recorre los números del 1 al 100. Usa un bucle for.
             */
            Console.WriteLine("Los números del 1 al 100 son : ");
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 1; i < 101; i++) {
                Console.WriteLine($"Numero: {i}");
                    }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ya se han recorido los 100 primeros números");
            Console.ReadKey();
        }
    }
}
