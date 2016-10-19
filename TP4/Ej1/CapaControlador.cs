using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaControlador
    {
        CapaAplicacion iCapaAplicacion;

        public CapaControlador(CapaAplicacion pCapaAplicacion)
        {
            iCapaAplicacion = pCapaAplicacion;
        }

        public void Ejecutar()
        {
            iCapaAplicacion.Ejecutar();
        }
    }
}
