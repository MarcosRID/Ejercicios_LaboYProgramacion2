using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Entidades
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="cantidadNums">Cantidad de numeros solicitados</param>
        /// <returns></returns>
        public static int[] ingresarNumeros(string mensaje, int cantidadNums)
        {

            int[] auxArray = new int[cantidadNums];

            Console.WriteLine(mensaje);

            for (int i = 0; i < cantidadNums; i++)
            {

                while (!int.TryParse(Console.ReadLine(), out auxArray[i]))
                {
                    Console.Clear();
                    Console.WriteLine(mensaje);
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            }


            return auxArray;
        }


        /// <summary>
        /// calcula cuantos años bisisestos hay entre 2 años como parametros
        /// </summary>
        /// <param name="anioMin"></param>
        /// <param name="anioMax"></param>
        /// <returns></returns>
        public static int[] calcularAniosBisiestos(int anioMin, int anioMax)
        {

            int auxAnio;
            int indice = 0;
            int[] arrayAnios = new int[anioMax - anioMin];

            for (int i = anioMin; i <= anioMax; i++)
            {
                auxAnio = Entidades.calcularAnioBisiesto(i);

                if (auxAnio != 0)
                {
                    arrayAnios[indice] = auxAnio;
                    indice++;
                }
            }

            if (indice != 0)
            {
                return arrayAnios;
            }

            return null;

        }

        /// <summary>
        /// Calcula si un año es bisiesto
        /// </summary>
        /// <param name="auxNum"></param>
        /// <returns></returns>
        private static int calcularAnioBisiesto(int auxNum)
        {
            if (auxNum % 4 == 0 || (auxNum % 100 == 0 && auxNum % 400 == 0))
            {
                return auxNum;
            }


            return 0;
        }


        /// <summary>
        /// Lista un array de int.
        /// </summary>
        /// <param name="arrayInt"></param>
        public static void listarNumeros(int[] arrayInt)
        {
            if (arrayInt != null)
            {
                string mensaje;

                Console.WriteLine("Lista de años bisiestos");

                foreach (int i in arrayInt)
                {
                    if (i == 0)
                    {
                        break;
                    }

                    Console.WriteLine(i);
                }

            }
            else
            {
                Console.WriteLine("No hay años bisiestos en este rango de años");
            }
        }


    }
}
