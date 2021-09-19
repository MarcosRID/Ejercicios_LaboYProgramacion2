using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_18_Geometria
{
    public class Punto
    {

        #region Atributos

        private int x;
        private int y;

        #endregion


        #region Constructores

        public Punto(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        #endregion


        #region Geters

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        #endregion



    }
}
