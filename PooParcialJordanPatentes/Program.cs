using POOPatente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooParcialJordanPatentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una patente para validar:");
            string patente = Console.ReadLine();

            ValidadorPatente.Validar(patente);

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadLine();
        }
    }
}
