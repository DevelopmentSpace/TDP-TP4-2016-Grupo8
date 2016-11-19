using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaPersistencia
    {
        /// <summary>
        /// Lanza una exepcion de tipo ErrorPuntualExeption
        /// </summary>
        public void Ejecutar()
        {
            ErrorPuntualException e = new ErrorPuntualException("ErrorPuntual", DateTime.Now);
            throw e;
        }
    }
}
