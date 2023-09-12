using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año = 0; int mes = 0; int dia = 0;

            Console.Write("Ingresar dia: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar año: ");
            año = Convert.ToInt32(Console.ReadLine());

            Console.Write($"El dia de la fecha es {año}:{mes}:{dia}");
            Console.ReadKey();
        }
    }
}
