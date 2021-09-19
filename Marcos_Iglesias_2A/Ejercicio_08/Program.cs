using System;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "Ejercicio 08";

            string[,] listaEmpleados = new string[50, 7];

            Entidades.listarEmpleados(Entidades.cargarEmpleados());



        }
    }
}
