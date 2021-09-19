using System;
using Clase_7_ejercicio_Entidades;


namespace Clase_7_Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Tempera tempera_Roja = new Tempera(ConsoleColor.Red, "Bic", 10);
            Tempera tempera_Azul = new Tempera(ConsoleColor.Blue, "Bic", 10);
            Tempera tempera_Negra = new Tempera(ConsoleColor.Black, "Bic", 10);
            Tempera tempera_Verde = new Tempera(ConsoleColor.Green, "Bic", 10);
            Tempera tempera_Blanco = new Tempera(ConsoleColor.White, "Bic", 10);
            Tempera tempera_Amarillo = new Tempera(ConsoleColor.Yellow, "Bic", 10);

            Tempera tempera_Roja2 = new Tempera(ConsoleColor.Red, "Bic", 20);
            Tempera tempera_Azul2 = new Tempera(ConsoleColor.Blue, "Bic", 10);
            Tempera tempera_Negra2 = new Tempera(ConsoleColor.Black, "Bic", 10);
            Tempera tempera_Verde2 = new Tempera(ConsoleColor.Green, "Bic", 10);
            Tempera tempera_Blanco2 = new Tempera(ConsoleColor.White, "Bic", 10);
            Tempera tempera_Amarillo2 = new Tempera(ConsoleColor.Yellow, "Bic", 10);

            Paleta paleta1 = 5;
            Paleta paleta2 = 6;

            //Cargo la primer paleta con 5 temperas
            paleta1 += tempera_Roja;
            paleta1 += tempera_Azul;
            paleta1 += tempera_Negra;
            paleta1 += tempera_Verde;
            paleta1 += tempera_Blanco;
            paleta1 += tempera_Amarillo;

            Console.WriteLine("Muestro las temperas cargadas");
            Console.WriteLine((string)paleta1);

            Console.WriteLine("Muestro y sumo 10 a la tempera roja");
            paleta1 += tempera_Roja;

            Console.WriteLine((string)paleta1);

            Console.WriteLine("Muestro y resto 20 a la tempera roja");
            paleta1 -= tempera_Roja2;

            Console.WriteLine((string)paleta1);


            //Cargo la segunda paleta con 6 temperas
            paleta2 += tempera_Roja2;
            paleta2 += tempera_Azul2;
            paleta2 += tempera_Negra2;
            paleta2 += tempera_Verde2;
            paleta2 += tempera_Blanco2;
            paleta2 += tempera_Amarillo2;

            Console.WriteLine("Muestro la segunda paleta");
            Console.WriteLine((string)paleta2);


            //Creo una tercer paleta
            Paleta paleta3 = paleta1 + paleta2;

            Console.WriteLine("Muestro la paleta 3 , que es el resultado de sumar paleta 1 y paleta 2");
            Console.WriteLine((string)paleta3);
        }
    }
}
