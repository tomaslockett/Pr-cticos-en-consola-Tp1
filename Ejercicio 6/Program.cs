using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int factorial = 1;

            Console.Write("ingrese el numero que quiere factorizal:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
            Console.ReadKey();
        }
    }
}
