using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";


            int numero = 0;
            int contador = 10;
            int max = 0;
            int min = 0;
            double acumulador = 0;
            double promedio;
            bool flag = false;
            bool error = false;

            for (int i = 0; i < contador; i++)
            {
                while (!flag)
                {
                    Console.Clear();

                    if (error)
                    {
                        Console.WriteLine("ERROR El valor debe estar entre el rango -100 y 100 (inclusive)");
                    }

                    numero = Validacion.pedirNumero($"Ingrese {i + 1}º numero (hasta {contador} numeros)");
                    flag = Validacion.Validar(numero, -100, 100);
                    error = !flag;
                }

                if (i != 0)
                {
                    max = Validacion.cacularMayor(numero, max);
                    min = Validacion.cacularMenor(numero, min);
                }
                else
                {
                    max = numero;
                    min = numero;
                }

                acumulador += numero;
                flag = false;
            }

            promedio = (double)acumulador / contador;

            Console.WriteLine($" Valor Maximo : {max}\n Valor Minimo : {min} \n Promedio {promedio}");

        }
    }
}
