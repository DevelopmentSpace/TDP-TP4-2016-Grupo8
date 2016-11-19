using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaAplicacionException : ApplicationException
    {
        /// <summary>
        /// Crea una instancia de CapaAplicacionException
        /// </summary>
        /// <param name="pMensaje">Mensaje</param>
        /// <param name="pInnerExeption">Excepcion que produjo la actual</param>
        public CapaAplicacionException(string pMensaje, Exception pInnerExeption):base(pMensaje,pInnerExeption)
        {
        }

    }
}
