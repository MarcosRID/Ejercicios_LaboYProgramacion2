using System;
using System.Text;


namespace Clase_5_TintaPluma
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;


        #region Constructores


        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ETipoTinta auxTinta) : this()
        {
            this.tipo = auxTinta;
        }

        public Tinta(ConsoleColor auxColor) : this()
        {
            this.color = auxColor;
        }

        public Tinta(ConsoleColor auxColor, ETipoTinta auxTinta)
        {
            this.color = auxColor;
            this.tipo = auxTinta;
        }



        #endregion


        #region Metodos

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine($"{this.tipo}\n");
            sb = sb.AppendLine($"{this.color}\n");

            return sb.ToString();
        }

        public static string Mostrar(Tinta t1)
        {
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine($"{t1.tipo}\n");
            sb = sb.AppendLine($"{t1.color}\n");

            return sb.ToString();
        }

        #endregion


        #region Sobrecarga Operadores

        public static bool operator  ==(Tinta t1, Tinta t2)
        {
            return (t1.color == t2.color) && (t1.tipo == t2.tipo);
        } 
        
        public static bool operator  !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        #endregion


        #region Explicito Implicito

        public static explicit operator string(Tinta t1)
        {
            return Tinta.Mostrar(t1);
        } 

        #endregion

      

    }
}
