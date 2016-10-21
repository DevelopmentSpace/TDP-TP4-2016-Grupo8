using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaAplicacionException : ApplicationException
    {

        public CapaAplicacionException(string pMensaje, Exception pInnerExeption):base(pMensaje,pInnerExeption)
        {
        }

    }
}
