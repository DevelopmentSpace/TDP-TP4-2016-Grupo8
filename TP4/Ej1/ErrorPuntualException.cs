using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class ErrorPuntualException : ApplicationException 
    {

        public ErrorPuntualException( String pMensaje,DateTime pFecha) : base(pMensaje)
        {
            this.Data.Add("fecha", pFecha);
        }  

    }
}
