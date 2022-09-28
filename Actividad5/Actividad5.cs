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
                    posicion = v + 1;
                    salir = true;
                }
            }

            return posicion;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {

            //TODO

            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            //TODO

            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            //TODO

            throw new NotImplementedException();


        }

        public static int contarPalabras(string entrada)
        {
            //TODO

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            //TODO

            throw new NotImplementedException();
        }
    }
}
