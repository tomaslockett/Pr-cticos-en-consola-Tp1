using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de kilobytes: ");
            int kilobytes = Convert.ToInt16(Console.ReadLine());

            int bytes = kilobytes * 1024;
            int bits = bytes * 8;

            Console.WriteLine("En {0} kilobytes hay {1} bits.", kilobytes, bits);
            Console.ReadKey();
        }
    }
}
