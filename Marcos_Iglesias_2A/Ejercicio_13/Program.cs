using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";

            int numero;
            string numeroBinario;

            numero = Conversor.ingresarNumero("Ingrese un numero");

            numeroBinario = Conversor.DecimalBinario(numero);
            Console.WriteLine($"{numeroBinario}");

            numero = Conversor.BinarioDecimal(numeroBinario);
            Console.WriteLine($"{numero}");
        }
    }
}
