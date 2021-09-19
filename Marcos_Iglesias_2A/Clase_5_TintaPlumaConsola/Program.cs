using System;
using Clase_5_TintaPluma; 

namespace Clase_5_TintaPlumaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pueba de clase 'Clase_5_TintaPluma'";

            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ConsoleColor.Red,ETipoTinta.China);

            Pluma pluma1 = new Pluma("Bic",tinta1,100);

            Console.WriteLine(pluma1);

            pluma1 -= tinta2;

            Console.WriteLine(pluma1);

            pluma1 -= tinta1;
        
            Console.WriteLine(pluma1);

        }
    }
}
