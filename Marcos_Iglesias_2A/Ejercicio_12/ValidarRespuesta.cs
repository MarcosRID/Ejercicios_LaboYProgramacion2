using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        /// <summary>
        /// Valida si es S o N;
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ValidarS_N(char c)
        {
            if (c == 'S' || c == 's')
            {
                return true;
            }
            else 
            {
                return false;
            }

        }


   

    }
}
