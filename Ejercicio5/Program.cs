using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
             */
            Console.WriteLine("Los números pares del 1 al 100.");
            Console.WriteLine(""); 
            Console.WriteLine("");
            //OPCIÓN 1
            //for (int i = 1; i < 101; i++)
            //{
            //    if((i % 2) == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }

            //}

            //Opción2 
            int num = 1;
            do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine($"NÚMERO PAR: {num}");
                }
                num++;

            } while (num <= 100);

            Console.ReadKey();

            
        }
    }
}
