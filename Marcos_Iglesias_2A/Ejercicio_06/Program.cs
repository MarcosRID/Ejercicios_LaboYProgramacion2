using System;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";


            int[] arrayAnios = new int[2];
            int[] arrayAniosBisiestos;


            arrayAnios = Entidades.ingresarNumeros("Ingrese añio de inicio y año final", 2);

            while (arrayAnios[0] >= arrayAnios[1])
            {
                arrayAnios = Entidades.ingresarNumeros("ERROR: Ingrese añio de inicio y año final", 2);
            }

            arrayAniosBisiestos = new int[arrayAnios[1] - arrayAnios[0]];

            arrayAniosBisiestos = Entidades.calcularAniosBisiestos(arrayAnios[0], arrayAnios[1]);

            Entidades.listarNumeros(arrayAniosBisiestos);
        }
    }
}
