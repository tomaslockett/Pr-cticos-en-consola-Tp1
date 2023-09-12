using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase: ");
            string x = Console.ReadLine();

            int longitud = x.Length;
            int mitad = longitud / 2;

            string primeraMitad = x.Substring(0, mitad);
            string segundaMitad = x.Substring(mitad);

            string resultado = segundaMitad + primeraMitad;

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
