using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public static class Entidades
    {

        /// <summary>
        /// Pide un numero por consola.
        /// </summary>
        /// <returns>retorna un entero validado</returns>
        public static int ingresarNumero(string mensaje)
        {
            int numero;

            Console.WriteLine(mensaje);

            while (!int.TryParse(Console.ReadLine(), out numero) && numero > 0)
            {
                Console.Clear();
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            return numero;
        }


        /// <summary>
        /// calcula si un numero es primo.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static int calcularNumeroPrimo(int numeroLimete)
        {
            bool flag = true;

            int[] arrayNum = new int[4];
            arrayNum[0] = 2;
            arrayNum[1] = 3;
            arrayNum[2] = 5;
            arrayNum[3] = 7;

            foreach (int i in arrayNum)
            {
                if (i == numeroLimete)
                {
                    return numeroLimete;
                }
            }

            foreach (int i in arrayNum)
            {
                if ((numeroLimete % i) == 0)
                {
                    return 0;
                }
                else if (numeroLimete == 1)
                {
                    return numeroLimete;
                }
            }

            return numeroLimete;
        }


        /// <summary>
        /// calcula en un array de int cuantos numeros primos hay
        /// </summary>
        /// <param name="arrayNum"></param>
        /// <returns></returns>
        public static int[] calcularNumerosPrimos(int num)
        {
            int[] auxArray = new int[50];
            int cantidad = 0;
            int auxNum;

            for (int i = 0; i < num; i++)
            {
                auxNum = Entidades.calcularNumeroPrimo(i);

                if (auxNum != 0)
                {
                    auxArray[cantidad] = auxNum;

                    cantidad++;
                }
            }

            return auxArray;
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
