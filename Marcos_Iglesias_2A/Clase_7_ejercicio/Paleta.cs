using System;
using System.Text;

namespace Clase_7_ejercicio_Entidades

{
    public class Paleta
    {
        private Tempera[] temperas;
        private int cantidadMaximaColores;


        #region Constructores


        private Paleta(int auxCantidad)
        {
            this.cantidadMaximaColores = auxCantidad;
            this.temperas = new Tempera[auxCantidad];
        }
        private Paleta() : this(5)
        { }        

        #endregion



        #region Metodos

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de temperas {this.cantidadMaximaColores}");
            sb.AppendLine($"-------------------------------------------------");
            sb.AppendLine($"Temperas en la Paleta");
            foreach (Tempera item in this.temperas)
            {
                if (item != null)
                {
                    sb.AppendLine(Tempera.Mostrar(item));
                }
            }

            return sb.ToString();
        }

        public int ObtenerIndice()
        {
            int rta = -1;

            for (int i = 0; i < this.temperas.Length; i++)
            {
                if (this.temperas[i] == null)
                {
                    rta = i;
                    break;
                }
            }

            return rta;
        }

        public int ObtenerIndice(Tempera t1)
        {
            int rta = -1;

            for (int i = 0; i < this.temperas.Length; i++)
            {
                if (this.temperas[i] != null && this.temperas[i] == t1)
                {
                    rta = i;
                    break;
                }
            }

            return rta;
        }

        #endregion



        #region Explicit/Implicit

        public static implicit operator Paleta(int tamanioPaleta)
        { return new Paleta(tamanioPaleta); }

        public static explicit operator string(Paleta p)
        { return p.Mostrar(); }

        #endregion



        #region Sobrecarga

        public static bool operator ==(Paleta p1, Tempera t1)
        {
            bool rta = false;

            foreach (Tempera item in p1.temperas)
            {
                if (item == t1)
                {
                    rta = true;
                }
            }

            return rta;
        }
    
        public static bool operator !=(Paleta p1, Tempera t1)
        { return !(p1 == t1); }


        /// <summary>
        /// Agrego una tempera al array de Temperas (si hay lugar NULL) en la instancia de paleta.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="t1"></param>
        /// <returns>Paleta</returns>
        public static Paleta operator +(Paleta p1, Tempera t1)
        {

            int indice = p1.ObtenerIndice(t1);

            if (indice >= 0)
            {
                p1.temperas[indice] += t1;
            }
            else
            {
                indice = p1.ObtenerIndice();

                if (indice >= 0)
                {
                    p1.temperas[indice] = t1;
                }
            }

            return p1;
        }


        public static Paleta operator -(Paleta p1, Tempera t1)
        {
            int indice = p1.ObtenerIndice(t1);
            int cantidad = 0;
            cantidad += (-t1);

            if (indice >= 0)
            {
                p1.temperas[indice] += cantidad;

                if (p1.temperas[indice] <= 0)
                {
                    p1.temperas[indice] = null;
                    p1.cantidadMaximaColores--;
                }
            }

            return p1;
        }


        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            int cantidad = p1.cantidadMaximaColores + p2.cantidadMaximaColores;
            int reperidas = 0;
            Paleta nuevaPaleta;

            //Cuanto cuantas temperas iguales hay.
            foreach (Tempera t1 in p1.temperas)
            {
                if (t1 != null)
                {
                    foreach (Tempera t2 in p2.temperas)
                    {
                        if (t1 == t2)
                        {
                            reperidas++;
                            break;
                        }
                    }
                }
            }


            cantidad -= reperidas;
            nuevaPaleta = new Paleta(cantidad);

            p1.temperas.CopyTo(nuevaPaleta.temperas, 0);

          
            foreach (Tempera item in p2.temperas)
            {
                nuevaPaleta += item;
            }

            return nuevaPaleta;
        }

        #endregion

 
    }
}
