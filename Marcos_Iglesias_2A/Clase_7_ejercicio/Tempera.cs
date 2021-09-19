using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7_ejercicio_Entidades
{
    public class Tempera
    {

        private ConsoleColor color;
        private string marca;
        private int cantidad;


        #region Constructores

        public Tempera(ConsoleColor auxColor, string auxMarca, int auxCantidad)
        {
            this.color = auxColor;
            this.marca = auxMarca;
            this.cantidad = auxCantidad;
        }

        #endregion



        #region Metodos

        /// <summary>
        /// Retorna un string con los datos de la tempera
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.color.ToString());
            sb.AppendLine(this.marca.ToString());
            sb.AppendLine(this.cantidad.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Retorna un string con los datos de la tempera
        /// </summary>
        /// <returns></returns>
        public static string Mostrar(Tempera t1)
        { return t1.Mostrar(); }

        #endregion



        #region Sobrecarga 

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool rta = false;

            if (t1 == (object)null && t2 == (object)null)
            {
                rta = true;
            }
            else if (t1 != (object)null && t2 != (object)null)
            {
                if (t1.marca.Equals(t2.marca) && t1.color == t2.color)
                {
                    rta = true;
                }
            }

            return rta;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
            {
                t1.cantidad += t2.cantidad;
            }

            return t1;
        }

        public static Tempera operator +(Tempera t1, int auxCantidad)
        {
            t1.cantidad += auxCantidad;
            return t1; 
        }

        #endregion



        #region Explicito/Implicito.

        public static implicit operator int(Tempera t1)
        { return t1.cantidad; }

        #endregion
        
    }
}
