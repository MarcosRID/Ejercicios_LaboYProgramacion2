using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Entidades
    {
        /// <summary>
        /// retorna los primeros 4 numeros perfectos
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static int[] calculaNumerosPerfectos()
        {
            int[] arrayNumPerfectos = new int[4];
            int num;
            int indice = 0;
            int iteraciones = 1;

            while (indice < 4)
            {
                num = Entidades.calculaNumeroPerfecto(iteraciones);
                iteraciones++;

                if (num != 0)
                {
                    arrayNumPerfectos[indice] = num;
                    indice++;
                }
            }

            return arrayNumPerfectos;

        }

        /// <summary>
        /// calcula si el numero es perfecto.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static int calculaNumeroPerfecto(int num)
        {
            int suma = 0;
            int indice = 0;
            int[] listaDivisores = new int[100];
            int i = 1;

            while (i < num)
            {

                if (num % i == 0)
                {
                    listaDivisores[indice] = i;
                    indice++;
                }

                i++;
            }

            if (listaDivisores[0] != 0)
            {

                for (i = 0; i < listaDivisores.Length; i++)
                {
                    suma += listaDivisores[i];
                }

                if (suma == num)
                {
                    return num;
                }

            }

            return 0;
        }

        /// <summary>
        /// Lista un array de int.
        /// </summary>
        /// <param name="arrayInt"></param>
        public static void listarNumeros(int[] arrayInt)
        {
            foreach (int i in arrayInt)
            {
                if (i != 0)
                {
                    Console.WriteLine($"{i}\n");
                }
            }
        }

    }
}
