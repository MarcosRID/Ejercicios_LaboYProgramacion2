using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_TintaPluma
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;



        #region Constructores

        private Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string auxMarca) : this()
        {
            this.marca = auxMarca;
        }

        public Pluma(string auxMarca, Tinta auxTinta) : this(auxMarca)
        {
            this.tinta = auxTinta;
        }

        public Pluma(string auxMarca, Tinta auxTinta, int auxCantidad) : this(auxMarca, auxTinta)
        {
            this.cantidad = auxCantidad;
        }

        #endregion



        #region Metodos

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine($"{this.marca}\n");
            sb = sb.AppendLine($"{this.cantidad}\n");
            sb = sb.AppendLine($"{((Tinta)this.tinta)}");

            return sb.ToString();
        }

        #endregion



        #region Sobrecarga Operador


        public static bool operator ==(Pluma p1, Tinta t1)
        {
            return p1.tinta == t1;
        }
        public static bool operator !=(Pluma p1, Tinta t1)
        {
            return !(p1 == t1);
        }


        public static Pluma operator +(Pluma p1, Tinta t1)
        {
            if (p1 == t1)
            {
                p1.cantidad++;
            }
            return p1;
        }

        public static Pluma operator -(Pluma p1, Tinta t1)
        {
            if (p1 == t1)
            {
                p1.cantidad--;
            }
            return p1;
        }

        #endregion



        #region  Explicit/Implicit

        public static implicit operator string(Pluma p1)
        {
            return p1.Mostrar();
        }

        #endregion


    }
}
