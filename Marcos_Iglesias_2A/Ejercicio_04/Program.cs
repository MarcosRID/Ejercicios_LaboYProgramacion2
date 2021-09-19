using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 

            Console.Title = "Ejercicio 04";
            #endregion

            int[] arrayInt = new int[4];

            arrayInt = Entidades.calculaNumerosPerfectos();

            Entidades.listarNumeros(arrayInt);
        }
    }
}
