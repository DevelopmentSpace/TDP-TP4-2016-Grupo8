using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class ErrorPuntualException : ApplicationException 
    {
        /// <summary>
        /// Crea una instancia de ErrorPuntualExcepcion
        /// </summary>
        /// <param name="pMensaje">Mensaje</param>
        /// <param name="pFecha">Fecha</param>
        public ErrorPuntualException( String pMensaje,DateTime pFecha) : base(pMensaje)
        {
            //Agrega la fecha al diccionario Data de la exepcion
            this.Data.Add("fecha", pFecha);
        }  

    }
}
