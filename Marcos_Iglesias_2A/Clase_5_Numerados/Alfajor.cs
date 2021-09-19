using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Numerados
{
    class Alfajor
    {

        private Alfajores nombre;
        private int precio;

        public Alfajor(Alfajores auxNombre , int auxPrecio)
        {
            this.nombre = auxNombre;
            this.precio = auxPrecio;
        }




        public static void Mostrar(Alfajor a)
        {

            Console.WriteLine($"nombre {a.nombre}");
            Console.WriteLine($"precio {a.precio } \n");

        }
    }
}
