using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Entidades
    {

        /// <summary>
        /// imprime una piramire
        /// </summary>
        /// <param name="altura"></param>
        public static void imprimirPiramide(int altura)
        {
            int alturaActual = 0;
            int contador = 1;
            int estacios = 10;

            do
            {
                if (contador % 2 != 0)
                {

                    for (int j = estacios; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int i = 0; i < contador; i++)
                    {

                        Console.Write("*");
                    }

                    Console.WriteLine();
                estacios--;
                }
                alturaActual++;
                contador++;

            } while (altura != alturaActual);

        }


    }
}
