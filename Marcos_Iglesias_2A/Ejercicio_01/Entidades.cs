using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public static class Entidades
    {

        public static int[] cargarArray(int cantidad)
        {
            int[] auxArray = new int[cantidad];

            for (int i = 0; i < auxArray.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out auxArray[i]))
                {
                    Console.WriteLine("Error en la carga, \"Solo numeros prositivos enteros\"");
                }
            }

            return auxArray;
        }

        public static int cacularMayor(int[] auxArray)
        {
            int numMax = 0 ;
            bool flag = true;

            foreach (int i in auxArray)
            {
                if (flag)
                {
                    numMax = i;
                    flag = false;
                }
                else
                {    
                    if (i == 0 || i > numMax)
                    {
                        numMax = i;
                    }
                }

            }

            return numMax;
        }
        
        public static int cacularMenor(int[] auxArray)
        {
            int numMin = 0;
            bool flag = true;

            foreach (int i in auxArray)
            {
                if (flag)
                {
                    numMin = i;
                    flag = false;
                }
                else
                {
                    if (i == 0 || i < numMin)
                    {
                        numMin = i;
                    }
                }
            }

            return numMin;
        }

        public static double carlularPromedio(int[] auxArray)
        {
            int cantidad = 0;
            int suma = 0;
            

            foreach (int i in auxArray)
            {
                suma += auxArray[cantidad];
                cantidad++;
            }

            return (double) suma / cantidad;
        }

    }
}
