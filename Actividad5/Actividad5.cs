using System;
using System.Linq;
using System.Text;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {
            StringBuilder cadena = new StringBuilder();
            for (int i = 0; i < vs.Length; i++)
            {
                cadena.Append(vs[i]);
            }

            return cadena.ToString();

            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {
            Array.Sort(vs);
            return devolverString(vs);

            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {
            String cadena = devolverString(vs);
            Boolean salir = false;
            int posicion = 0;

            for (int i = 0; i < cadena.Length && !salir; i++)
            {
                if (cadena[i] == v)
                {
                    posicion = i + 1;
                    salir = true;
                }
            }

            return posicion;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            int[] sumados = new int[vs1.Length];

            for (int i = 0; i < sumados.Length; i++)
            {
                sumados[i] = vs1[i] + vs2[i];
            }

            return sumados;

            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            int[] multiplicados = new int[vs1.Length];

            for (int i = 0; i < multiplicados.Length; i++)
            {
                multiplicados[i] = vs1[i] * vs2[i];
            }

            return multiplicados;

            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            String palabra = (String)entrada.Replace(" ", String.Empty).ToLower();

            String arbalap = palabra.Reverse().ToString();

            return palabra.SequenceEqual(arbalap);

            throw new NotImplementedException();
        }

        public static int contarPalabras(string entrada)
        {
            string[] palabras = entrada.Split(" ");

            return palabras.Length - 1;

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            String palabra = (String)entrada.Replace(" ", String.Empty);
            return palabra.Length;

            throw new NotImplementedException();
        }
    }
}
