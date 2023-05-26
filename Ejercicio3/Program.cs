using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Pedir al usuario que introduzca que día de la semana
             es hoy y decirle si es fin de semana o no. Utilizar if/else
            */
            // FORMA 1 
            WriteLine("Dime que día de la semana es hoy: ");
            string dayUser = ReadLine();
            string day1 = "Sabado";
            string day2 = "Domingo";
            if (dayUser.ToUpper() == day1.ToUpper() || dayUser.ToUpper() == day2.ToUpper())
            {
                WriteLine("Que suerte! Es fin desemana, a disfrutar!");
            }
            else
            {
                WriteLine($"Que pena, aún es {dayUser}, faltan unos días para el fin de semana.");
            }
            ReadLine();


        }
    }
}
