using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fecha1;
            string fecha2;
            Console.Write("Ingrese la fecha 1 (dd/mm/aaaa): ");
            fecha1 = Console.ReadLine();
            Console.Write("Ingrese la fecha 2 (dd/mm/aaaa): ");
            fecha2 = Console.ReadLine();
            if (DateTime.TryParse(fecha1, out DateTime fechaInicio) && DateTime.TryParse(fecha2, out DateTime fechaFin))
            {
                TimeSpan diferencia = fechaFin - fechaInicio;
                int diferenciaEnDias = diferencia.Days;

                Console.Write($"La diferencia entre las fechas es de {diferenciaEnDias} días.");
            }
            else
            {
                Console.Write("Una o ambas fechas ingresadas no son válidas.");
            }
            Console.ReadKey();
        }
    }
}
