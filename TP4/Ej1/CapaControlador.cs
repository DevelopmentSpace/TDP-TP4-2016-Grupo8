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

        /// <summary>
        /// Crea una instancia de CapaControlador
        /// </summary>
        /// <param name="pCapaAplicacion">CapaAplicacion</param>
        public CapaControlador(CapaAplicacion pCapaAplicacion)
        {
            iCapaAplicacion = pCapaAplicacion;
        }

        /// <summary>
        /// Invoca el mensaje ejecutar() de la CapaAplicaicon
        /// </summary>
        public void Ejecutar()
        {
            iCapaAplicacion.Ejecutar();
        }
    }
}
