using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_18_Geometria;

namespace Ejercicio_18_PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(10, 50);
            Punto punto2 = new Punto(20, 100);
            Rectangulo rectangulo = new Rectangulo(punto1, punto2);

            Console.WriteLine(Rectangulo.listarCaracteristicas(rectangulo));
        }
    }
}
