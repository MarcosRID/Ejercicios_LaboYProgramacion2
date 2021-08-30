using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {


            double exponenteCuadrado;
            double exponenteCubo;

            exponenteCuadrado = Entidades.calcularExponente(Entidades.ingresarNumero("Ingrese numero"),2);
        
            exponenteCubo = Entidades.calcularExponente(Entidades.ingresarNumero("Ingrese numero"), 3);

            Console.WriteLine($" Exponente al cuadrado {exponenteCuadrado} \n Exponente al cubo {exponenteCubo} ");
        }
    }
}
