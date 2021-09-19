using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Clase_4
{
    class Cosa
    {
        #region atributos

        private int entero;
        private string cadena;
        private DateTime fecha;
        #endregion

        #region Constructores

        public Cosa()
        {

        }

        public Cosa(string auxCadena) : this()
        {
            this.cadena = auxCadena;
        }
        public Cosa(int auxEntero, string auxCadena) : this(auxCadena)
        {
            this.entero = auxEntero;
        }
        public Cosa(DateTime auxFecha, int auxEntero, string auxCadena) : this(auxEntero, auxCadena)
        {
            this.fecha = auxFecha;
        }

        #endregion


        #region Metodos


        public void establecerValor(int auxEntero)
        {
            this.entero = auxEntero;
        }
        public void establecerValor(string auxCadena)
        {
            this.cadena = auxCadena;
        }
        public void establecerValor(DateTime auxFecha)
        {
            this.fecha = auxFecha;
        }


        private string mostrar()
        {
            string rta = string.Format($" Entero {this.entero}\n Cadena {this.cadena} \n Fecha {this.fecha}");

            return rta;
        }
        public static string mostrar(Cosa auxCosa)
        {
            return auxCosa.mostrar();
        }

        #endregion

        /*clase Cosa
            *-*-*-*-*-*-
       
               * -*-*-*-*-*-*-*-*-*-*
               (+) EstablecerValor(int):void
               (+) EstablecerValor(string):void
               (+) EstablecerValor(DateTime):void
               *-*-*-*-*-*-*-*-*-*
               (-) Mostrar():string -> de instancia
               (+) Mostrar(Cosa):string -> de clase
            *-*-*-*-*-*-*-*-*-*
         
            --->en todos los casos la fecha por defecto debe ser la actual(a menos que se reciba por parámetro)
            --->los valores predeterminados serán:
                        10-> int
            "sin valor"-> string
            'Now'->DateTime
            Contraer
            */
    }
}
