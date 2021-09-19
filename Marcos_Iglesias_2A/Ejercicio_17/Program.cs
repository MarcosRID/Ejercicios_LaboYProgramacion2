using System;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            string pintar ;
            Boligrafo boligrafo1 = new Boligrafo(100 , ConsoleColor.Red);


            if (boligrafo1.pintar(50, out pintar))
            {
                Console.WriteLine(pintar);
            }
            else
            {
                Console.WriteLine("No hay tinta");
            }
        }
    }
}
