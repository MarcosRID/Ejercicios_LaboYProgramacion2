using System;
using Clase_5_Entidades;


namespace Clase_5_SobreCarga_Operadores_
{
    class Program
    {
        static void Main(string[] args)
        {

            Numero n1 = new Numero(5);
            Numero n2 = new Numero(5);


            if (n1 == n2)
            {
                Console.WriteLine("Son iguales");
            }
            
            if (n1 != n2)
            {
                Console.WriteLine("Son distintos");
            }

        }
    }
}
