using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejrcico 12";

            ConsoleKeyInfo respuesta = new ConsoleKeyInfo();
            int suma = 0;
            int numero;
            string mensaje = "Ingrese numero";

            do
            {
                Console.WriteLine(mensaje);

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Clear();
                    Console.WriteLine(mensaje);
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

                suma += numero;

                Console.Clear();
                Console.WriteLine("Sedesa continuar S/N");
                respuesta = Console.ReadKey();
                Console.Clear();

            } while (ValidarRespuesta.ValidarS_N(respuesta.KeyChar));

            Console.WriteLine($"Suma total: {suma}");
        }
    }
}
