using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {

        /// <summary>
        /// Calcula el area de un cuadrado.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double CalcularCuadrado(double num)
        {
            //El area de un cuadrado es el priducto de su altura por la base.
            return (double)(num * num);
        }


        /// <summary>
        /// Calcula el area un un trangulo.
        /// </summary>
        /// <param name="baseTriangulo">Base</param>
        /// <param name="alturaTriangulo">Altura</param>
        /// <returns></returns>
        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            //El area de un triangulo es el procto de la base por la altura , dividido 2.
            return (double)(baseTriangulo * alturaTriangulo) / 2;
        }


        /// <summary>
        /// Calcula el area de un circulo en base a su diametro
        /// </summary>
        /// <param name="diametroCirculo">Diametro</param>
        /// <returns></returns>
        public static double CalcularCirculo(double diametroCirculo)
        {
            //El area de un circulo es dividiendo el diametro por 2 " D/2 "
            //Luego calcular Area por PI por Radio al cuadrado " A = Pi * R^2"

            double radio = (double)diametroCirculo / 2;

            double area = (double)3.14 * Math.Pow(radio,2);

            return area;
        }


    }
}
