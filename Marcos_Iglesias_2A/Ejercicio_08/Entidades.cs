using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    static class Entidades
    {
        /*
          indices 0 : Nombre empleado.
                  1 : Años de antigüedad.
                  2 : Hs trabajadas.
                  3 : Valor/hs.
                  4 : Total a cobrar.
                  5 : Total de descuento.
                  6 : Total a cobrar en neto.
                  7 : ID empleado.   
          */
        private static string[,] listaEmpleados = new string[50, 8];
        private static int id = 0;

        public static string[,] cargarEmpleados()
        {
           // char continuar = 'Y';
           // string[] array = new string[8];


            //cargo la matriz para no tener problemas al compararla 
            /*  for (int f = 0; f < listaEmpleados.GetLength(0); f++)
              {

                  for (int c = 0; c < array.Length; c++)
                  {
                      listaEmpleados[f, c] = " ";
                  }
              }*/

            do
            {
                Entidades.cargarMatriz(listaEmpleados, out listaEmpleados, Entidades.cargarEmpleado());

            } while (Entidades.confirmar("Desea cargar mas empleados Y/N"));

            Entidades.calcularImporteEmpleados(listaEmpleados, out listaEmpleados);

            return listaEmpleados;
        }

        /// <summary>
        /// Carga un empleado creado a la lista.
        /// </summary>
        /// <param name="auxMatriz"></param>
        /// <param name="matriz"></param>
        /// <param name="array"></param>
        private static void cargarMatriz(string[,] auxMatriz, out string[,] matriz, string[] array)
        {

            for (int f = 0; f < auxMatriz.GetLength(0); f++)
            {
                if (string.IsNullOrEmpty(auxMatriz[f, 7]))
                {

                    for (int c = 0; c < array.Length; c++)
                    {
                        auxMatriz[f, c] = array[c];
                    }

                    matriz = auxMatriz;

                    break;
                }

            }
            matriz = auxMatriz;
        }


        /// <summary>
        /// Crea un empleado.
        /// </summary>
        /// <returns></returns>
        private static string[] cargarEmpleado()
        {
            /*
            indices 0 : Nombre empleado.
                    1 : Años de antigüedad.
                    2 : Hs trabajadas.
                    3 : Valor/hs.
                    4 : Total a cobrar.
                    5 : Total de descuento.
                    6 : Total a cobrar en neto.
                    7 : ID empleado.   
            */
            string[] empleado = new string[8];

            Console.WriteLine("Ingrese nombre : ");
            empleado[0] = Console.ReadLine();

            while (Entidades.validarNombre(empleado[0]))
            {
                Console.WriteLine("ERROR (El  campo nombre no puede contener : \n            -Numeros \n            -Estar vacio, estar)Ingrese nombre : ");
                empleado[0] = Console.ReadLine();
            }


            Console.WriteLine("Ingrese años de antigüedad: ");
            empleado[1] = Console.ReadLine();

            while (!Entidades.validarNumero(empleado[1]))
            {
                Console.WriteLine("ERROR (El  campo años no puede contener : \n            -Letras \n            -Estar vacio, estar)Ingrese nombre : ");
                empleado[1] = Console.ReadLine();
            }


            Console.WriteLine("Ingrese Horas trabajadas: ");
            empleado[2] = Console.ReadLine();

            while (!Entidades.validarNumero(empleado[2]))
            {
                Console.WriteLine("ERROR (El  campo  Horas trabajadas no puede contener : \n            -Letras \n            -Estar vacio, estar)Ingrese nombre : ");
                empleado[2] = Console.ReadLine();
            }


            Console.WriteLine("Ingrese Valos/Hora: ");
            empleado[3] = Console.ReadLine();

            while (!Entidades.validarNumero(empleado[3]))
            {
                Console.WriteLine("ERROR (El  campo Valos/Hora no puede contener : \n            -Letras \n            -Estar vacio, estar)Ingrese nombre : ");
                empleado[3] = Console.ReadLine();
            }

            empleado[7] = (id++).ToString();

            return empleado;
        }

        /// <summary>
        /// calcula los datos de los empleados.
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="auxMatriz"></param>
        private static void calcularImporteEmpleados(string[,] matriz, out string[,] auxMatriz)
        {
            int num1;
            int num2;
            int num3;
            double total = 0;


            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                if (!string.IsNullOrEmpty(matriz[f, 7]))
                {

                    int.TryParse(matriz[f, 1], out num1);
                    int.TryParse(matriz[f, 2], out num2);
                    int.TryParse(matriz[f, 3], out num3);

                    total = (double)num2 * num3;
                    total += (num1 * 150);

                    matriz[f, 4] = total.ToString();
                    matriz[f, 5] = "-%13";

                    matriz[f, 6] = ((double)total - (total * 13 / 100)).ToString();

                }
                else
                {
                    break;
                }

            }

            auxMatriz = matriz;
        }

        /// <summary>
        /// Lista los datos de cada empleado
        /// </summary>
        /// <param name="empleados"></param>
        public static void listarEmpleados(string[,] empleados)
        {
            Console.WriteLine("(Nombre empleado) (Años/antigüedad) (Hs/trabajadas) (Valor/hs) (Total a cobrar) (Total/descuento) (Total/cobrar neto) *ID*");

            for (int f = 0; f < empleados.GetLength(0); f++)
            {
                //Falta identar mejor la tabla impresa en este for
                if (!string.IsNullOrEmpty(empleados[f, 7]))
                {
                    Console.WriteLine($"{empleados[f, 0]} {empleados[f, 1]} {empleados[f, 2]} {empleados[f, 3]} {empleados[f, 4]} {empleados[f, 5]} {empleados[f, 6]} {empleados[f, 7]}");
                }
            }
        }

        /// <summary>
        /// Valida si un string es solo numerico.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        private static bool validarNumero(string numString)
        {
            int num;

            return int.TryParse(numString, out num);
        }


        /// <summary>
        /// Valida si cumple con las caracteristicas de NOMBRE
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private static bool validarNombre(string nombre)
        {

            if (String.IsNullOrEmpty(nombre) && String.IsNullOrWhiteSpace(nombre))
            {
                foreach (char i in nombre)
                {
                    if (i < '9' && i > '0')
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }


        /// <summary>
        /// Creado para preguntar si "desea continuar".
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        private static bool confirmar(string mensaje)
        {
            string letra;

            while (true)
            {
                Console.WriteLine(mensaje);
                letra = (Console.ReadLine()).ToUpper();

                foreach (char i in letra)
                {

                    if (i == 'Y')
                    {
                        return true;
                    }
                    else if (i == 'N')
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR solo ingrese Y/N");
                    }
                }
            }
        }



    }
}
