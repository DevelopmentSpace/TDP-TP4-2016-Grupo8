using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    public class DivisionPorCeroException : Exception
    {
        /// <summary>
        /// Crea una instancia de DivisionPorCeroException
        /// </summary>
        /// <param name="pMensaje">Mensaje</param>
        public DivisionPorCeroException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
