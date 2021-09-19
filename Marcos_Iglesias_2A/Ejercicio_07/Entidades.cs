using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Entidades
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="cantidadNums">Cantidad de numeros solicitados</param>
        /// <returns></returns>
        public static int[] ingresarNumeros(string mensaje, int cantidadNums)
        {

            int[] auxArray = new int[cantidadNums];

            Console.WriteLine(mensaje);

            for (int i = 0; i < cantidadNums; i++)
            {

                while (!int.TryParse(Console.ReadLine(), out auxArray[i]))
                {
                    Console.Clear();
                    Console.WriteLine(mensaje);
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            }


            return auxArray;
        }


        /// <summary>
        /// Pide una fecha.
        /// </summary>
        /// <returns></returns>
        public static string ingresarFecha()
        {
            //indice 0 = Dia
            //indice 1 = Mes
            //indice 2 = Anio
            int[] fechaNacimiento = new int[3];
            bool[] arrayConfirmacion = new bool[3];

            
         
            while (!arrayConfirmacion[0] || !arrayConfirmacion[1] || !arrayConfirmacion[2])
            {
                if (!arrayConfirmacion[0])
                {
                    Console.WriteLine("Eldato ingresado en el campo DIA es erreno");
                }
                
                if (!arrayConfirmacion[1])
                {
                    Console.WriteLine("Eldato ingresado en el campo MES es erreno");
                }
                
                if (!arrayConfirmacion[2])
                {
                    Console.WriteLine("Eldato ingresado en el campo AÑO es erreno");
                }

                fechaNacimiento = Entidades.ingresarNumeros("Ingrese fecha (dd/mm/aaaa): ", 3);
                arrayConfirmacion = Entidades.verificarFecha(fechaNacimiento);

            }

            

            return string.Format($" {fechaNacimiento[0]}/{fechaNacimiento[1]}/{fechaNacimiento[2]} ");
        }
      
        
        /// <summary>
        /// verificar si es correcto la fecha y su formato dd/mm/aaaa.
        /// </summary>
        /// <param name="auxArray"></param>
        /// <returns></returns>
        private static bool[] verificarFecha(int[] auxArray)
        {
            bool[] confirmacion = new bool[3];

            if ((auxArray[1] == 2) && (0 != Entidades.calcularAnioBisiesto(auxArray[2])))
            {

                if (auxArray[0] > 0 && auxArray[0] < 30)
                {
                    confirmacion[0] = true;
                    confirmacion[1] = true;
                    confirmacion[2] = true;
                }

                return confirmacion;
            }



            if (auxArray[2] >= 1900 && auxArray[2] <= 2021)
            {
                confirmacion[2] = true;
            }
            else
            {
                confirmacion[2] = false;
            }


            switch (auxArray[1])
            {
                case 2:

                    if (auxArray[0] >= 1 && auxArray[0] <= 28)
                    {
                        confirmacion[1] = true;
                        confirmacion[0] = true;
                    }

                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    if (auxArray[0] >= 1 && auxArray[0] <= 31)
                    {
                        confirmacion[1] = true;
                        confirmacion[0] = true;
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (auxArray[0] >= 1 && auxArray[0] <= 30)
                    {
                        confirmacion[1] = true;
                        confirmacion[0] = true;
                    }
                    break;

                default:

                    if (auxArray[0] >= 1 && auxArray[0] <= 31)
                    {
                        confirmacion[1] = false;
                        confirmacion[0] = true;
                    }

                    confirmacion[1] = false;
                    confirmacion[0] = false;

                    break;
            }


            return confirmacion;
        }


        /// <summary>
        /// verifica si el anio ingresado mayo a 1900 sea bisiesto.
        /// </summary>
        /// <param name="auxNum"></param>
        /// <returns></returns>
        private static int calcularAnioBisiesto(int auxNum)
        {
            if (auxNum % 4 == 0 || (auxNum % 100 == 0 && auxNum % 400 == 0) && auxNum > 1900)
            {
                return auxNum;
            }

            return 0;
        }

        /// <summary>
        /// calcula los dias vividos
        /// </summary>
        /// <param name="auxFecha"></param>
        public static void mostrarDiasVividos(string auxFecha)
        {
            DateTime fecha = Convert.ToDateTime(auxFecha);

             int diasVividos = (DateTime.Now - fecha).Days;

            Console.WriteLine($"Lleva {diasVividos} dias vividos");
        }



    }
}
