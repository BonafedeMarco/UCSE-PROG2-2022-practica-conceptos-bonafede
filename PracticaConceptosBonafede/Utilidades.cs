using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConceptosBonafede
{
    public static class Utilidades
    {
        public static int ContarPalabras(this string input) // Punto 1
        {
            string[] palabras = input.Split(' ');
            return palabras.Count();
        }
    }
}
