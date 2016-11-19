using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaDominio
    {
        CapaPersistencia iCapaPersistencia;

        /// <summary>
        /// Crea una instancia de CapaDominio
        /// </summary>
        /// <param name="pCapaPersistencia">CapaPersistencia</param>
        public CapaDominio(CapaPersistencia pCapaPersistencia)
        {
            iCapaPersistencia = pCapaPersistencia;
        }

        /// <summary>
        /// Invoca el mensaje ejecutar() de la CapaPersistencia
        /// </summary>
        public void Ejecutar()
        {
            iCapaPersistencia.Ejecutar();
        }

    }
}
