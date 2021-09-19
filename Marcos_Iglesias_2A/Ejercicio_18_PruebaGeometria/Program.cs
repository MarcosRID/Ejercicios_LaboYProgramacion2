using System;
using Ejercicio_18_Geometria;

namespace Ejercicio_18_PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(10, 10);
            Punto punto2 = new Punto(20, 20);
            Rectangulo rectangulo = new Rectangulo(punto1, punto2);

            Rectangulo.listarCaracteristicas(rectangulo);
        }
    }
}

