using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
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

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Clear();
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            return numero;
        }


        /// <summary>
        /// eleva a un numero entero el exponente ingresado
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="exponente"></param>
        /// <returns></returns>
        public static double calcularExponente(int numero, int exponente)
        {

            if (numero > 0 )
            {
                return Math.Pow(numero, exponente);
            }

            return 0;
        }


    }
}
