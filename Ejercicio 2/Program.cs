using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lado = 0;
            int superficie = 0;
            Console.Write("ingrese el lado del cuadrado");
            lado = Convert.ToInt32(Console.ReadLine());
            superficie = lado * lado;
            Console.WriteLine("El valor total de la superficie es de:{0}", superficie);
            Console.ReadKey();


        }
    }
}
