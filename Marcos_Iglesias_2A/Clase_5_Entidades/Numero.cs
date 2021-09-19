using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Entidades
{
    public class Numero
    {

        public double valor;

        public Numero(double auxValor)
        {
            this.valor = auxValor;
        }

        #region Sobrecarga de operadores

        public static bool operator ==(Numero n1, Numero n2)
        {
            return n1.valor == n2.valor;
        }

        public static bool operator !=(Numero n1, Numero n2)
        {
            return n1 == n2;
        }



        #endregion

    }
}
