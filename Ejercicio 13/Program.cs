using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Fecha2020 = new DateTime(2020, 12, 25);
            DateTime Hoy = DateTime.Now;

            TimeSpan diferencia = Fecha2020 - Hoy;
            int Faltante = diferencia.Hours;

            Console.WriteLine("Faltan un total de {0} días para el 25/12/2020.", Faltante);
            Console.ReadKey();
        }
    }
}
