using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejerccio 16";

            #region Alunmos


            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Valentina";
            alumno1.apellido = "Gomes ";
            alumno1.legajo = 1994;

            alumno2.nombre = "Delfina";
            alumno2.apellido = "Aguirre";
            alumno2.legajo = 1996;
            
            alumno3.nombre = "Santino";
            alumno3.apellido = "Paz";
            alumno3.legajo = 1997;

            #endregion

            alumno1.estudiar(8,7);
            alumno2.estudiar(7,6);
            alumno3.estudiar(1,9);

            alumno1.calcularFinal();
            alumno2.calcularFinal();
            alumno3.calcularFinal();


            Console.WriteLine("Nombre  Apellido Legajo 1º/n  2º/n  NotaFinal");

            Console.WriteLine(alumno1.mostrar());
            Console.WriteLine(alumno2.mostrar());
            Console.WriteLine(alumno3.mostrar());

        }
    }
}
