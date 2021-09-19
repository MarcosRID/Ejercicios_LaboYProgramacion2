using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";

            int centroNumerico;
            int[] gruposNumericos;

            centroNumerico = Entidades.ingresarNumero("Ingrese numero para calcular su centro numerico");
            gruposNumericos = Entidades.calcularCentroNumerico(centroNumerico);
            Entidades.listarNumeros(gruposNumericos);

        }
    }
}
