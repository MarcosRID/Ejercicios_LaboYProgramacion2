using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";

            double numero1, numero2;
            string operador;
            ConsoleKeyInfo respuesta = new ConsoleKeyInfo();


            do
            {

                numero1 = Calculadora.ingresarNumero("Ingrese 1º numero");

                Console.Clear();
                operador = Calculadora.ingresarOperador();

                Console.Clear();
                numero2 = Calculadora.ingresarNumero("Ingrese 2º numero");

                Console.Clear();
                Calculadora.Calcular(numero1, numero2, operador);



                Console.WriteLine("Sedesa continuar S/N");
                respuesta = Console.ReadKey();
                Console.Clear();

            } while (Calculadora.ValidarS_N(respuesta.KeyChar));
        }
    }
}
