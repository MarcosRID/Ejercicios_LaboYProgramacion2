using System;

namespace Ejercicio_1_Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "1º Ejercicio en clase 4";

            Cosa cosa1 = new Cosa(DateTime.Now, 10, "sin valor");

            Console.Write(Cosa.mostrar(cosa1));
        }
    }
}
