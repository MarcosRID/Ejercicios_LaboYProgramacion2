using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Entidades
    {

        /// <summary>
        /// imprime un triangulo recto de asteriscos
        /// </summary>
        /// <param name="altura"></param>
        public static void imprimirTriangulo(int altura)
        {
            int alturaActual = 0;
            int contador = 1;

            do
            {
                if (contador % 2 != 0)
                {
                    for (int i = 0; i < contador; i++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
                alturaActual++;
                contador++;

            } while (altura != alturaActual);

        }

    }
}
