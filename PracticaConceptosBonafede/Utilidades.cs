using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticaConceptosBonafede
{
    public static class Utilidades
    {
        // Punto 1
        public static int ContarPalabras(this string input)
        {
            string[] palabras = input.Split(' ');
            return palabras.Count();
        }

        // Punto 2
        public static int ContarPalabras(this string input, char separador)
        {
            string[] palabras = input.Split(separador);
            return palabras.Count();
        }

        // Punto 3
        public static decimal CalcularDiferenciaEnMinutos(this DateTime fechaA, DateTime fechaB)
        {
            return Convert.ToDecimal(Math.Sqrt((fechaA.Second - fechaB.Second)^2)) * 60;
        }

        // Punto 4
        public static double ObtenerPromedio(this List<int> listaEnteros)
        {
            return listaEnteros.Average();
        }

        private static bool EsPar(this int numero)
        {
            if ((numero / 2) == (Convert.ToDouble(numero) / 2))
            {
                return true;
            }
            return false;
        }

        // Punto 5
        public static int ObtenerSumaParesPorRestaImpares(this List<int> listaEnteros)
        {
            int sumaPares = 0;
            int restaImpares = 0;
            foreach (int numero in listaEnteros)
            {
                if (numero.EsPar())
                    sumaPares += numero;
                else
                    restaImpares -= numero;
            }
            return sumaPares * restaImpares;
        }

        // Punto 6
        public static DateTime ConvertirStringAFecha(this string input)
        {
            DateTime fecha;
            try
            {
                string[] valores = input.Split('/');
                fecha = new DateTime(Convert.ToInt32(valores[2]), Convert.ToInt32(valores[1]), Convert.ToInt32(valores[0]));
            }
            catch (Exception)
            {
                fecha = DateTime.MinValue;
            }
            return fecha;
        }

        // Punto 7
        public static string InvertirString(this string input)
        {
            return input.Reverse().ToString();
        }

        // Punto 8
        public static string ConcatenarArrayStrings(this string[] array, char separador)
        {
            return string.Join(separador.ToString(), array);
        }

        // Punto 9
        public static bool EsEmailValido(this string input)
        {
            return Regex.IsMatch(input, @"[\w.]+@+[\w.]+");
        }

        // Punto 10
        public static bool EsCUITValido(this string input)
        {
            return Regex.IsMatch(input, @"\d{2}-\d{8}-\d{2}");
        }
    }
}
