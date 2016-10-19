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

        public CapaDominio(CapaPersistencia pCapaPersistencia)
        {
            iCapaPersistencia = pCapaPersistencia;
        }

        public void Ejecutar()
        {
            iCapaPersistencia.Ejecutar();
        }

    }
}
