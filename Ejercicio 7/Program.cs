using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase1;
            string frase2; 
            Console.Write("ingrese una parte de la frase:");
            frase1 = Console.ReadLine();

            Console.Write("ingrese la otra parte de la frase:");
            frase2 = Console.ReadLine();


            string resultado = frase1 + frase2; 

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
