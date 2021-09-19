using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static void Calcular(double numero1, double numero2, string operador)
        {

            if (operador.Equals("+"))
            {
                Console.WriteLine($"resultado de la suma: {Calculadora.sumar(numero1, numero2)}");
            }
            else if (operador.Equals("-"))
            {
                Console.WriteLine($"resultado de la resta: {Calculadora.resta(numero1, numero2)}");
            }
            else if (operador.Equals("*"))
            {
                Console.WriteLine($"resultado de la multiplicar: {Calculadora.multiplicar(numero1, numero2)}");
            }
            else if (operador.Equals("/"))
            {
                Console.WriteLine($"resultado de la dividir: {Calculadora.dividir(numero1, numero2)}");
            }

        }

        private static double sumar(double numero1, double numero2)
        { return numero1 + numero2; }
        private static double resta(double numero1, double numero2)
        { return numero1 - numero2; }
        private static double multiplicar(double numero1, double numero2)
        { return numero1 * numero2; }
        private static double dividir(double numero1, double numero2)
        {
            if (Calculadora.Validar(numero2))
            {
                return numero1 / numero2;
            }
            return -1;
        }

        private static bool Validar(double divisor)
        {
            if (divisor == 0)
            {
                return false;
            }

            return true;
        }

        private static bool ValidarOperador(string operador)
        {
            if (operador.Equals("/") || operador.Equals("*") || operador.Equals("-") || operador.Equals("+"))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Valida si es S o N;
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ValidarS_N(char c)
        {
            if (c == 'S' || c == 's')
            {
                return true;
            }
            else
            {
                return false;
            }

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


        /// <summary>
        /// Pide por consola un operador.
        /// </summary>
        /// <returns></returns>
        public static string ingresarOperador()
        {
            string msj = "Ingrese operador \"/\" \"*\" \"+\" \"-\" ";
            string operador;

            Console.WriteLine(msj);
            operador = Console.ReadLine();


            while (!Calculadora.ValidarOperador(operador))
            {
                Console.Clear();
                Console.WriteLine("ERROR. ¡Reingresar operador!");
                operador = Console.ReadLine();
            }

            return operador;
        }
    }
}
