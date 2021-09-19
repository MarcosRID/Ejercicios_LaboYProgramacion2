using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 

            Console.Title = "Ejercicio 01";
            #endregion

            int cantidad = 5;
            int[] array_numeros = new int[cantidad];

            int numMax = 0;
            int numMin = 0;
            double promedio;

            Console.WriteLine("Ingrese 5 numeros");

            array_numeros = Entidades.cargarArray(cantidad);

            numMax = Entidades.cacularMayor(array_numeros);
            numMin = Entidades.cacularMenor(array_numeros);
            promedio = Entidades.carlularPromedio(array_numeros);

            Console.WriteLine($" Numero maximo : {numMax}\n Numero minimo : {numMin} \n Promedio : {promedio}");

         
        }
    }
}
