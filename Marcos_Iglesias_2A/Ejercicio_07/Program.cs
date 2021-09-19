using System;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";

            string fechaS;

            fechaS = Entidades.ingresarFecha();

            Entidades.mostrarDiasVividos(fechaS);
        }
    }
}
