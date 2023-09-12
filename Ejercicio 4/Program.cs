using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circunferencia, diametro;

            Console.Write("Ingrese el valor de la circunferencia: ");
            circunferencia = double.Parse(Console.ReadLine());

            diametro = circunferencia / Math.PI;

            Console.WriteLine("El diámetro del círculo es: {0}", diametro);
            Console.ReadKey();
        }
    }
}
