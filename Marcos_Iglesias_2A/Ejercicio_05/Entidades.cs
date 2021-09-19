using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Entidades
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
        /// Calcula el SI el numero ingresado es un centro numerico.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] calcularCentroNumerico(int num)
        {
            int sumaPrimaria = 0;
            int sumaSecundaria = 0;
            int numSecundario = num;
            int[] arrayNum = new int[4];



            for (int i = 1; i < num; i++)
            {
                sumaPrimaria += i;
            }

            while ((sumaPrimaria != sumaSecundaria) && (sumaPrimaria > sumaSecundaria))
            {
                numSecundario++;
                sumaSecundaria += numSecundario;
            }

            if (sumaPrimaria == sumaSecundaria)
            {
                arrayNum[0] = 1;
                arrayNum[1] = (num - 1);
                arrayNum[2] = (num + 1);
                arrayNum[3] = numSecundario;

                return arrayNum;
            }

            return null;
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
                mensaje = string.Format($" Gruro 1 de {arrayInt[0]} a {arrayInt[1]} \n Grupo 2 de {arrayInt[2]} a {arrayInt[3]}");

                Console.WriteLine(mensaje);
            }
            else
            {
                Console.WriteLine("Este numero no es un centro numerico");
            }
        }


    }
}
