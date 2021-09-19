using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {

        #region Atributos

        short cantidadTintaMaxima;
        private short tinta;
        private ConsoleColor color;

        #endregion


        #region Constructores

        Boligrafo()
        {
            this.cantidadTintaMaxima = 100;
        }

        public Boligrafo(short auxTinta, ConsoleColor auxColor) : this()
        {
            this.tinta = auxTinta;
            this.color = auxColor;
        }

        #endregion


        #region Geters

        public ConsoleColor getColor()
        {
            return this.color;
        }

        public short getTinta()
        {
            return this.tinta;
        }

        #endregion


        #region Seters

        private void setTinta(short auxTinta)
        {
            if ((this.tinta + (tinta)) >= 0 && (this.tinta + (tinta)) <= 100)
            {
                this.tinta = auxTinta;
            }
            else if ((this.tinta + (tinta)) < 0)
            {
                this.tinta = 0;
            }
            else if ((this.tinta + (tinta)) > 100)
            {
                this.tinta = 100;
            }
        }

        #endregion


        #region  Metodos

        public bool pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            short cantidadTinta = this.getTinta();
            Console.ForegroundColor= this.color;

            if (gasto > 0)
            {
                short.TryParse( $"-{gasto}",out gasto);
            }

            if (cantidadTinta < 0)// si no hay titnta me voy
            {
                return false;
            }

            if (gasto <= cantidadTinta)//si gasto menos o igual a la cantidad de tinta que tengo , pinto.
            {
                cantidadTinta += gasto;
            }
           /* else if (gasto > cantidadTinta)//si quiero gastar mas de lo que tengo , pinto con cantidadTinta
            {
                                                    ///CODIGO REDUDNDANTE
                cantidadTinta = this.getTinta();    ///CODIGO REDUDNDANTE
                                                    ///CODIGO REDUDNDANTE
            }*/

            for (int i = 0; i < cantidadTinta; i++)
            {
                dibujo = string.Concat(dibujo, string.Format("*"));
            }


            this.setTinta(gasto);

            return true;
        }

        public void recargar()
        {
            this.setTinta(100);
        }




        #endregion

    }
}
