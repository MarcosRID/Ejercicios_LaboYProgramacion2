using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {

        /// <summary>
        /// Conbierte un numero entero a binario.
        /// </summary>
        /// <param name="numeroAcomvertir"></param>
        /// <returns></returns>
        public static string DecimalBinario(int numeroAcomvertir)
        {
            int numero = numeroAcomvertir;
            string numeroBinario = "";

            do
            {

                if (numero == 0)
                {
                    numeroBinario = string.Format($"0{numeroBinario}");
                    return numeroBinario;
                }
                else if (numero == 1)
                {
                    numeroBinario = string.Format($"1{numeroBinario}");
                    return numeroBinario;
                }


                if (numero % 2 == 0)
                {
                    numeroBinario = string.Format($"0{numeroBinario}");
                }
                else
                {
                    numeroBinario = string.Format($"1{numeroBinario}");
                }

                numero = numero / 2;


            } while (true);

        }



        /// <summary>
        /// Pasa de binario a decimar.
        /// </summary>
        /// <param name="numeroAcomvertir"></param>
        /// <returns></returns>
        public static int BinarioDecimal(string numeroAcomvertir)
        {
            double numero = 0;
            int exponente = (numeroAcomvertir.Length - 1);


            foreach (char i in numeroAcomvertir)
            {

                if (i == '1')
                {
                    numero += Math.Pow(2, exponente);
                }

                exponente--; ;
            }

            return (int)numero;
        }


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
    }
}
