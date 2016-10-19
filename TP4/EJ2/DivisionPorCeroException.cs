using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class DivisionPorCeroException : Exception
    {

        public DivisionPorCeroException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
