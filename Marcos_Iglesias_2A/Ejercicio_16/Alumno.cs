using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        #region Campos/atributos

        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;
        #endregion

        #region Metodos

        public void calcularFinal()
        {

            if (nota1 >= 4 && nota2 >= 4)
            {
                Random randomFinal = new Random();
                notaFinal = randomFinal.Next();
            }

            notaFinal = -1;
        }

        public void estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public string mostrar()
        {
            string rta;
            rta = string.Format($"{this.nombre} {this.apellido} {this.legajo} {this.nota1} {this.nota2} {this.notaFinal}");

            return rta;
        }
        


        #endregion

    }
}
