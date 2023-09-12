using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Lado1 = 0;
            int Lado2 = 0;
            int Lado3 = 0;
            int petrimetro = 0;

            Console.WriteLine("Ingrese el lado 1 del triangulo:");
            Lado1 = 
            Lado1 = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Ingrese el lado 2 del triangulo:");
            Lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el lado 3 del triangulo:");
            Lado3 = Convert.ToInt32(Console.ReadLine());

            petrimetro = Lado1 + Lado2 + Lado3;
            Console.WriteLine("El total del petrimetro es de {0}", petrimetro);

            Console.ReadKey();
        }
    }
}
