using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            int opcion;
            double num1;
            double num2;
            string mensaje = "Seleccione una opción -Calcular el area de un: \n1) Cuadrado \n2) Triangulo \n3) Cierculo";

            Console.WriteLine(mensaje);

            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Clear();
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }


            switch (opcion)
            {
                case 1:

                    Console.WriteLine("Ingrese el diametro del cuadrado");

                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR. ¡Reingresar número! ");
                    }

                    Console.WriteLine($"El area de cuadrado es:{CalculoDeArea.CalcularCuadrado(num1)}");

                    break;
                case 2:

                    Console.WriteLine("Ingrese numero para la base del triangulo");

                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR. ¡Reingresar dato numer! (Base)");
                    }

                    Console.WriteLine("Ingrese dato para la Altura");

                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR. ¡Reingresar número! (Altura)");
                    }

                    Console.WriteLine($"El area de cuadrado es:{CalculoDeArea.CalcularTriangulo(num1,num2)}");

                    break;
                case 3:

                    Console.WriteLine("Ingrese Diametro del ciculo");

                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR. ¡Reingresar número! (Diametro)");
                    }

                    Console.WriteLine($"El area de cuadrado es:{CalculoDeArea.CalcularCirculo(num1)}");

                    break;

                default:
                    break;
            }



        }
    }
}
