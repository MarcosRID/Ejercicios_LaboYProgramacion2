using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {

        /// <summary>
        /// Valida que este en un rango determinado el Valor.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {

            if (valor >= min && valor <= max)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Pide un numero por consola.
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static int pedirNumero(string mensaje)
        {
            int numero;

            Console.WriteLine(mensaje);

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            return numero;
        }


        /// <summary>
        /// Retorna el numero mayor de un array de enteros
        /// </summary>
        /// <param name="auxArray"></param>
        /// <returns></returns>
        public static int cacularMayor(int auxNumero, int numMax)
        {

            if (auxNumero > numMax)
            {
                return auxNumero;
            }

            return numMax;
        }


        /// <summary>
        /// retorna el numero mas chico de un array de enteros
        /// </summary>
        /// <param name="auxArray"></param>
        /// <returns></returns>
        public static int cacularMenor(int auxNumero, int numMin)
        {


            if (auxNumero < numMin)
            {
                return auxNumero;
            }


            return numMin;
        }



    }
}
