using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18_Geometria
{
    public class Rectangulo
    {
        #region Atributos

        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        #endregion



        #region Constructores


        public Rectangulo(Punto vertice_1, Punto vertice_3)
        {
            this.vertice1 = vertice_1;
            this.vertice2 = new Punto(vertice_1.getX(), vertice_3.getY());
            this.vertice3 = vertice_3;
            this.vertice4 = new Punto(vertice_3.getX(), vertice_1.getY());
        }

        #endregion



        #region Geters

         float getArea()
        {
            int baseRec = this.vertice4.getX() - this.vertice1.getX();
            int alturaRec = this.vertice2.getY() - this.vertice1.getY();

            this.area = Math.Abs(baseRec * alturaRec);

            return this.area;
        }

         float getPerimetro()
        {
            int baseRec = this.vertice4.getX() - this.vertice1.getX();
            int alturaRec = this.vertice2.getY() - this.vertice1.getY();

            this.perimetro = Math.Abs((baseRec + alturaRec) * 2);

            return this.perimetro;
        }

        #endregion



        #region Metodos

        public float pedirArea()
        {
            return this.getArea();
        }

        public float pedirPerimetro()
        {
            return this.getPerimetro();
        }

        public static string listarCaracteristicas(Rectangulo rectangulo_1)
        {
            string cadena;
            cadena = string.Format($" Area: {rectangulo_1.pedirArea()}\n Perimetro {rectangulo_1.pedirPerimetro()} \n Base { rectangulo_1.vertice4.getX() - rectangulo_1.vertice1.getX() } Altura: { rectangulo_1.vertice2.getY() - rectangulo_1.vertice1.getY()}");

            return cadena;
        }
        #endregion

    }
}
