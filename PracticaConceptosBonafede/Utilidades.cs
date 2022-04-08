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
            return palabras.Count(); //podria ser una sola linea
        }

        // Punto 2
        public static int ContarPalabras(this string input, char separador)
        {
            string[] palabras = input.Split(separador);
            return palabras.Count(); //podria ser una sola linea
        }

        // Punto 3
        public static decimal CalcularDiferenciaEnMinutos(this DateTime fechaA, DateTime fechaB)
        {
            return Convert.ToDecimal(Math.Sqrt((fechaA.Second - fechaB.Second)^2)) * 60;
        }

        // Punto 4
        public static double ObtenerPromedio(this List<int> listaEnteros) //no hace falta "enteros" en el nombre
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
            //ver de usar lambda
            return sumaPares * restaImpares;
        }

        // Punto 6
        public static DateTime ConvertirStringAFecha(this string input)
        {
            DateTime fecha;
            try
            {
                string[] valores = input.Split('/');
                //podria usar DateTime.Parse()
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

        // Punto 13
        public static int Restar(this int minuendo, int sustraendo)
        {
            return minuendo - sustraendo;
        }

        // Punto 14 (falta terminar)
        //public static Int32 operator /(Int32 a, Int32 b)
        //{
        //    return (int)(((decimal)(a / b) % 1) * 100);
        //}
    }
}
