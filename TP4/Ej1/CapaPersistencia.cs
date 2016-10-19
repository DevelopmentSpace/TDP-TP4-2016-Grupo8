using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaPersistencia
    {

        public void Ejecutar()
        {
            ErrorPuntualException e = new ErrorPuntualException("Mensaje ErrorPuntual", DateTime.Now);
            throw e;
        }
    }
}
