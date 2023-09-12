using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1 = 0;
            int lado2 = 0;
            int superficie= 0;
            

            Console.Write("ingrese el lado 1 del rectangulo:");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el lado 2 del rectangulo:");
            lado2 = Convert.ToInt32(Console.ReadLine());

            superficie = lado1 * lado2;
            Console.WriteLine("El tamaño del superficie es de:{0}", superficie);
            Console.ReadKey();


        }
    }
}
