using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPatente
{
    public static class ValidadorPatente
    {
        public static bool Validar(string patente)
        {
            var formatoAnterior = EsFormatoAnterior(patente);

            var formatoNuevo = EsFormatoNuevo(patente);

            if (formatoAnterior || formatoNuevo)
            {
                Console.WriteLine("La patente es válida.")
                    ;
                return true;
            }
            else
            {
                Console.WriteLine("La patente no es válida.");
                return false;
            }
        }

        private static bool EsFormatoAnterior(string patente)
        {
            if (patente.Length == 7 && char.IsLetter(patente[0]) && char.IsLetter(patente[1]) && char.IsLetter(patente[2])
                              && char.IsDigit(patente[4]) && char.IsDigit(patente[5]) && char.IsDigit(patente[6])
                              && patente[3] == ' ')
            {
                return true;
            }
            return false;
        }

        private static bool EsFormatoNuevo(string patente)
        {
            if (patente.Length == 8 && char.IsLetter(patente[0]) && char.IsLetter(patente[1]) && char.IsDigit(patente[3]) && char.IsDigit(patente[4]) && char.IsDigit(patente[5]) && char.IsLetter(patente[7]))
            {
                return true;
            }
            return false;
        }


    }
}





