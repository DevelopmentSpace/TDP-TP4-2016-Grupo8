using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class SaldoException : ApplicationException
    {

        public SaldoException(string pMensaje) : base(pMensaje)
        {
        }

    }
}
