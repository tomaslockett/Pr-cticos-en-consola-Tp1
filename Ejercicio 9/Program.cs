using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            int cantidadCaracteres = frase.Length;

            Console.WriteLine("La frase tiene {0} caracteres.", cantidadCaracteres);
            Console.ReadKey();
        }
    }
}
