using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 

            Console.Title = "Ejercicio 03";
            #endregion

            int numero;
            int[] arrayInt = new int[50];

            numero = Entidades.ingresarNumero("Ingresar limite numerico ");

            arrayInt = Entidades.calcularNumerosPrimos(numero);

            Entidades.listarNumeros(arrayInt);

        }
    }
}
